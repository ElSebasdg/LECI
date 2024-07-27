using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using Bunifu.Framework.UI;

namespace ChinSell
{
    public partial class catálogo : Form
    {
        private string ID;
        private string connectionString = @"Data Source=tcp:mednat.ieeta.pt\SQLSERVER,8101;Initial Catalog=p2g4;Persist Security Info=True;User ID=p2g4;Password=bd.deti1602";
        SqlCommand com = new SqlCommand();
        public catálogo()
        {
            InitializeComponent();
        }

        private void catálogo_Load(object sender, EventArgs e)
        {
            display_produtos();
        }

        public void display_produtos()
        {
            string query = "SELECT produto_id, Preço, Marca, Título, imagem_url from list_catalog";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dt.Columns.Add("Pic", Type.GetType("System.Byte[]"));
                    foreach (DataRow drow in dt.Rows)
                    {
                        drow["Pic"] = File.ReadAllBytes(drow["imagem_url"].ToString());
                    }

                    dgb_catalogo.DataSource = dt;
                }
            }
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Perfil catalog = new Perfil();
            catalog.ReceberUserId(ID);
            catalog.ShowDialog();
        }

        public void ReceberUserId(string userId)
        {
            // receber ID
            ID = userId;
            Console.WriteLine(userId);
            // MessageBox.Show("User ID: " + userId);
            // lbl_gotoprofile.Text = lbl_gotoprofile.Text + ": " + userId;
        }

        private void refresh_página()
        {
            display_produtos();
            dgb_catalogo.Refresh();
            this.Refresh();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh_página();
        }

        private void btn_comprar_Click(object sender, EventArgs e)
        {
            txtbox_idproduto.Text = "";
            lbl_idproduto.Visible = !lbl_idproduto.Visible;
            txtbox_idproduto.Visible = !txtbox_idproduto.Visible;
            btn_comprartheproduct.Visible = !btn_comprartheproduct.Visible;
        }

        private bool IsIdPresentInDatabase(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM CHINSELL.PRODUTO WHERE produto_id = @ProdutoId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProdutoId", id);
                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        public bool BuscarProdutoIdtoEliminate()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM CHINSELL.PRODUTO WHERE produto_id = @ProdutoId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    do
                    {
                        int produtoId;
                        if (Int32.TryParse(txtbox_idproduto.Text, out produtoId))
                        {
                            if (IsIdPresentInDatabase(produtoId))
                            {
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@ProdutoId", produtoId);
                                return true;
                            }
                            else
                                return false;
                  
                        }
                    }
                    while (true);
                }

            }
        }

        private void btn_comprartheproduct_Click(object sender, EventArgs e)
        {
            bool idproduto = BuscarProdutoIdtoEliminate();// ID

            if (idproduto == true)
            {
                MessageBox.Show("ID Existe!", "Finalize a sua compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_finalizarcompra.Visible = true;
            }
            else if(idproduto == false)
            {
                btn_finalizarcompra.Visible=false;
                MessageBox.Show("Id não existe", "Verifique se o ID inserido está correto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_finalizarcompra_Click(object sender, EventArgs e)
        {


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string s = "CHINSELL.EliminarProduto";
                SqlCommand cmd = new SqlCommand(s, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@produto_id ", txtbox_idproduto.Text);

                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produto comprado com sucesso.");
                    txtbox_idproduto.Text = "";
                    btn_finalizarcompra.Visible = false;
                    lbl_idproduto.Visible = false;
                    txtbox_idproduto.Visible = false;
                    btn_comprartheproduct.Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha na compra. \n ERROR MESSAGE: \n" + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}