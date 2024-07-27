using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Bunifu.Framework.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;

namespace ChinSell
{
    public partial class Perfil : Form
    {
        private string ID;
        private string connectionString = @"Data Source=tcp:mednat.ieeta.pt\SQLSERVER,8101;Initial Catalog=p2g4;Persist Security Info=True;User ID=p2g4;Password=bd.deti1602";
        private string numTelemovel;
        private string email;
        private int categoriaId;
        private int subcategoriaId;


        public Perfil()
        {
            InitializeComponent();
        }


        private void Perfil_Load(object sender, EventArgs e)
        {
            BuscarDadosUtilizador();

            username_txtBox.Text = email;
            numTele_txtBox.Text = numTelemovel;
            display_subcat();
            tabela_produtos();

        }


        public void ReceberUserId(string userId)
        {
            // receber ID
            ID = userId;
            Console.WriteLine(userId);
            //MessageBox.Show("User ID: " + userId);
        }

        // Dar display nas textbox da info do user do perfil
        public void BuscarDadosUtilizador()
        {
            string query = "SELECT Num_Telemovel, Email FROM CHINSELL.UTILIZADOR WHERE id = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            numTelemovel = reader["Num_Telemovel"].ToString();
                            email = reader["Email"].ToString();
                       
                        }
                    }
                }
            }
        }


        // Dar display na DatagridBox dos produtos do usuário
        public void tabela_produtos()
        {
            string query = "SELECT produto_id, Preço, Marca, Título, imagem_url FROM CHINSELL.PRODUTO WHERE vendedor_id = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dt.Columns.Add("Pic", Type.GetType("System.Byte[]"));
                    foreach (DataRow row in dt.Rows)
                    {
                        row["Pic"] = File.ReadAllBytes(row["imagem_url"].ToString());
                    }

                    dgv_myCatalogo.DataSource = dt;
                }
            }
        }


        // Botão para dar display do formulário para adicionar um novo produto
        private void btb_adicionarProduto_Click(object sender, EventArgs e)
        {

            lbl_idproduto.Visible = false;
            txtbox_idproduto.Visible = false;
            btn_idpesquisa.Visible = false;

            txtbox_idproduto.Text = "";


            lbl_Título.Visible = !lbl_Título.Visible;
            lbl_preço.Visible = !lbl_preço.Visible;
            lbl_marca.Visible = !lbl_marca.Visible;
            lbl_categoria.Visible = !lbl_categoria.Visible;
            lbl_subcategoria.Visible = !lbl_subcategoria.Visible;

            txtBox_marca.Visible = !txtBox_marca.Visible;
            txtBox_preco.Visible = !txtBox_preco.Visible;
            txtBox_titulo.Visible = !txtBox_titulo.Visible;
            txtBox_imagemPath.Visible = !txtBox_imagemPath.Visible;

            comboBox_categoria.Visible = !comboBox_categoria.Visible;
            comboBox_subcategoria.Visible = !comboBox_subcategoria.Visible;

            btn_procurarimagem.Visible = !btn_procurarimagem.Visible;
            btn_idpesquisa.Visible = false;
            btn_pesquisarideliminate.Visible = false;




            txtBox_marca.Text = "";
            txtBox_preco.Text = "";
            txtBox_titulo.Text = "";
            txtBox_imagemPath.Text = "";

            comboBox_categoria.SelectedIndex = -1;
            comboBox_subcategoria.SelectedIndex = -1;

        }

        private void txtBox_preco_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            char ch = e.KeyChar;


            if (!Char.IsDigit(ch) && ch != 8 && ch != 46) // 8 -> backspace, 46 -> . 
            {
                e.Handled = true;
            }


        }

        // botao para obter caminho de uma imagem e copiar o caminho para a txtBox_imagemPath
        private void btn_procurarimagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                txtBox_imagemPath.Text = imagePath;
            }
        }



        // Dar display das categorias dos produtos do utilizador
        public void display_subcat()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryCategoria = "SELECT categoria_id, Nome FROM CHINSELL.CATEGORIA";
                using (SqlCommand commandCategoria = new SqlCommand(queryCategoria, connection))
                {
                    using (SqlDataReader readerCategoria = commandCategoria.ExecuteReader())
                    {
                        while (readerCategoria.Read())
                        {
                            categoriaId = Convert.ToInt32(readerCategoria["categoria_id"]);
                            string nomeCategoria = readerCategoria["Nome"].ToString();
                            comboBox_categoria.Items.Add(new CategoriaItem(categoriaId, nomeCategoria));
                        }
                    }
                }
            }
        }

        // dar display das subcategorias dependendo da categoria escolhida
        private void comboBox_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtonVisibility();
            comboBox_subcategoria.Items.Clear();
            comboBox_subcategoria.SelectedIndex = -1;

            if (comboBox_categoria.SelectedItem is CategoriaItem selectedCategoria)
            {
                categoriaId = selectedCategoria.CategoriaId;


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string querySubcategoria = "SELECT subcategoria_id, Nome FROM CHINSELL.SUBCATEGORIA WHERE categoria_id = @CategoriaId";
                    using (SqlCommand commandSubcategoria = new SqlCommand(querySubcategoria, connection))
                    {
                        commandSubcategoria.Parameters.AddWithValue("@CategoriaId", categoriaId);

                        using (SqlDataReader readerSubcategoria = commandSubcategoria.ExecuteReader())
                        {
                            while (readerSubcategoria.Read())
                            {
                                subcategoriaId = Convert.ToInt32(readerSubcategoria["subcategoria_id"]);
                                string nomeSubcategoria = readerSubcategoria["Nome"].ToString();
                                comboBox_subcategoria.Items.Add(new SubcategoriaItem(subcategoriaId, nomeSubcategoria));
                            }
                        }
                    }
                }
            }
        }


        // Dar display na DatagridBox dos produtos do usuário
        public int GerarProdutoIdUnico()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM CHINSELL.PRODUTO WHERE produto_id = @ProdutoId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    Random random = new Random();
                    int produtoId;

                    do
                    {
                        produtoId = random.Next(100000, 999999);
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@ProdutoId", produtoId);
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count == 0)
                        {
                            // produto_id único encontrado
                            return produtoId;
                        }
                    }
                    while (true);
                }
            }
        }

        private void UpdateButtonVisibility()
        {
            bool comboBox_subcat = comboBox_subcategoria.SelectedIndex == -1;
            bool comboBox_cat = comboBox_categoria.SelectedIndex == -1;

            if (!(txtBox_titulo.Text == "")
                && !(txtBox_preco.Text == "")
                && !(txtBox_marca.Text == "")
                && !(comboBox_categoria.Text == "") 
                && !(comboBox_subcategoria.Text == "")
                && !(txtBox_imagemPath.Text == "")
                && (txtbox_idproduto.Text == "")
                && !comboBox_subcat
                && !comboBox_cat)
            {
                btn_add.Visible = true;
                btn_editconfirm.Visible = false;
            }
            else
            {
                btn_add.Visible = false;
                btn_editconfirm.Visible = true;
            }
        }



        private void txtBox_titulo_OnValueChanged(object sender, EventArgs e)
        {
            UpdateButtonVisibility();
        }

        private void txtBox_preco_OnValueChanged(object sender, EventArgs e)
        {
            UpdateButtonVisibility();
        }

        private void txtBox_marca_OnValueChanged(object sender, EventArgs e)
        {
            UpdateButtonVisibility();
        }

        private void txtBox_imagemPath_OnValueChanged(object sender, EventArgs e)
        {
            UpdateButtonVisibility();
        }

        private void comboBox_subcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtonVisibility();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int newidproduct = GerarProdutoIdUnico(); // ID único e irrepetível

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                //string s = "select PF.AdicionarCliente(@Nome, @Endereço, @Nº_CC, @Género, @Email, @Nome_Empresa)";
                string s = "CHINSELL.AdicionarProduto";
                SqlCommand cmd = new SqlCommand(s, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@produto_id ", newidproduct);
                cmd.Parameters.AddWithValue("@Preço", txtBox_preco.Text.ToString());
                cmd.Parameters.AddWithValue("@Marca", txtBox_marca.Text.ToString());
                cmd.Parameters.AddWithValue("@Título", txtBox_titulo.Text.ToString());
                cmd.Parameters.AddWithValue("@imagem_url", txtBox_imagemPath.Text.ToString());
                cmd.Parameters.AddWithValue("@categoria_id", categoriaId);
                cmd.Parameters.AddWithValue("@subcategoria_id", subcategoriaId);
                cmd.Parameters.AddWithValue("@vendedor_id",ID);
                string triggerSql = @"
                    CREATE TRIGGER CHINSELL.addproduct ON CHINSELL.PRODUTO
                    AFTER INSERT, UPDATE
                    AS 
                    BEGIN
	                    SET NOCOUNT ON;
	                    DECLARE @Preço AS float;
	                    DECLARE @Marca AS varchar(20);
	                    DECLARE @Título AS varchar(50);
	                    DECLARE @erro VARCHAR(100)

	                    IF @Preço < 0.0
	                    BEGIN
		                    SELECT @erro = ERROR_MESSAGE();
		                    SET @erro = 'Preço Inválido!'
		                    ROLLBACK TRAN;
	                    END

	                    IF LEN(@Título) = 0
	                    BEGIN
		                    SELECT @erro = ERROR_MESSAGE();
		                    SET @erro = 'Insira um título válido!'
		                    ROLLBACK TRAN;
	                    END

	                    IF LEN(@Marca) = 0
	                    BEGIN
		                    SELECT @erro = ERROR_MESSAGE();
		                    SET @erro = 'Insira uma marca válida!'
		                    ROLLBACK TRAN;
	                    END
                    END";


                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produto adicionado com sucesso.");
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to add product in database. \n ERROR MESSAGE: \n" + ex.Message);
                }
                finally
                {
                    con.Close();
                }

            }
        }

        private void btn_editconfirm_Click(object sender, EventArgs e)
        {

            int idproduto = BuscarProdutoId();//bunifuMaterialTextbox1.; // ID 


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                //string s = "select PF.AdicionarCliente(@Nome, @Endereço, @Nº_CC, @Género, @Email, @Nome_Empresa)";
                string s = "CHINSELL.EditarProduto";
                SqlCommand cmd = new SqlCommand(s, con);
                cmd.CommandType = CommandType.StoredProcedure;
                

                cmd.Parameters.AddWithValue("@produto_id ", idproduto);
                cmd.Parameters.AddWithValue("@Preço", txtBox_preco.Text);
                cmd.Parameters.AddWithValue("@Marca", txtBox_marca.Text.ToString());
                cmd.Parameters.AddWithValue("@Título", txtBox_titulo.Text.ToString());
                cmd.Parameters.AddWithValue("@imagem_url", txtBox_imagemPath.Text.ToString());
                cmd.Parameters.AddWithValue("@categoria_id", categoriaId);
                cmd.Parameters.AddWithValue("@subcategoria_id", subcategoriaId);
                cmd.Parameters.AddWithValue("@vendedor_id", ID);

                //string marca = row["Marca"].ToString();
                ////(float)Convert.ToDouble(txtBox_preco.Text
                //float preco = (float)Convert.ToDouble(row["Preço"]);
                //string titulo = row["Título"].ToString();
                //string imagemPath = row["imagem_url"].ToString();
                //int categoriaId = Convert.ToInt32(row["categoria_id"]);
                //int subcategoriaId = Convert.ToInt32(row["subcategoria_id"]);
                //string categoriaNome = row["categoria_nome"].ToString();
                //string subcategoriaNome = row["subcategoria_nome"].ToString();

                //txtBox_marca.Text = marca;
                //txtBox_preco.Text = preco.ToString();
                //txtBox_titulo.Text = titulo;
                //txtBox_imagemPath.Text = imagemPath;
                //comboBox_categoria.Text = categoriaNome;
                //comboBox_subcategoria.Text = subcategoriaNome;

                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produto editado com sucesso.");
                    txtbox_idproduto.Text = "";
                    lbl_Título.Visible = false;
                    lbl_preço.Visible = false;
                    lbl_marca.Visible = false;
                    lbl_categoria.Visible = false;
                    lbl_subcategoria.Visible = false;

                    txtBox_marca.Visible = false;
                    txtBox_preco.Visible = false;
                    txtBox_titulo.Visible = false;
                    txtBox_imagemPath.Visible = false;

                    comboBox_categoria.Visible = false;
                    comboBox_subcategoria.Visible = false;

                    btn_procurarimagem.Visible = false;
                    btn_add.Visible = false;
                    btn_editconfirm.Visible = false;
  

                    btn_confirmareliminar.Visible = false;

                    txtBox_marca.Text = "";
                    txtBox_preco.Text = "";
                    txtBox_titulo.Text = "";
                    txtBox_imagemPath.Text = "";

                    comboBox_categoria.SelectedIndex = -1;
                    comboBox_subcategoria.SelectedIndex = -1;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to edit product in database. \n ERROR MESSAGE: \n" + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }

        }

        private void dgv_myCatalogo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_editarProduto_Click(object sender, EventArgs e)
        {
            txtbox_idproduto.Text = "";
            lbl_idproduto.Visible = true;
            txtbox_idproduto.Visible = true;
            btn_idpesquisa.Visible = true;

            lbl_Título.Visible = false;
            lbl_preço.Visible = false;
            lbl_marca.Visible = false;
            lbl_categoria.Visible = false;
            lbl_subcategoria.Visible = false;

            txtBox_marca.Visible = false;
            txtBox_preco.Visible = false;
            txtBox_titulo.Visible = false;
            txtBox_imagemPath.Visible = false;

            comboBox_categoria.Visible = false;
            comboBox_subcategoria.Visible = false;

            btn_procurarimagem.Visible = false;
            btn_add.Visible= false;
            btn_editconfirm.Visible = false;
            btn_idpesquisa.Visible = true;
            btn_pesquisarideliminate.Visible = false;

            txtBox_marca.Text = "";
            txtBox_preco.Text = "";
            txtBox_titulo.Text = "";
            txtBox_imagemPath.Text = "";

            comboBox_categoria.SelectedIndex = -1;
            comboBox_subcategoria.SelectedIndex = -1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            btn_add.Visible = false;
        }

       

       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btn_add.Visible = false;
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

        private void btn_idpesquisa_Click(object sender, EventArgs e)
        {
            string query = @"SELECT p.Marca, p.Preço, p.Título, p.imagem_url, p.categoria_id, p.subcategoria_id, c.Nome AS categoria_nome, s.Nome AS subcategoria_nome
                     FROM CHINSELL.PRODUTO p
                     INNER JOIN CHINSELL.CATEGORIA c ON p.categoria_id = c.categoria_id
                     INNER JOIN CHINSELL.SUBCATEGORIA s ON p.subcategoria_id = s.subcategoria_id
                     WHERE p.produto_id = @ProductID AND p.vendedor_id = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductID", txtbox_idproduto.Text);
                    command.Parameters.AddWithValue("@ID", ID);

                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];

                        lbl_Título.Visible = true;
                        lbl_preço.Visible = true;
                        lbl_marca.Visible = true;
                        lbl_categoria.Visible = true;
                        lbl_subcategoria.Visible = true;

                        txtBox_marca.Visible = true;
                        txtBox_preco.Visible = true;
                        txtBox_titulo.Visible = true;
                        txtBox_imagemPath.Visible = true;

                        comboBox_categoria.Visible = true;
                        comboBox_subcategoria.Visible = true;

                        btn_procurarimagem.Visible = true;
                        btn_confirmareliminar.Visible = false;
                        btn_editconfirm.Visible = true;
                        btn_confirmareliminar.Visible = false;
                        btn_pesquisarideliminate.Visible = false;


                        string marca = row["Marca"].ToString();
                        //(float)Convert.ToDouble(txtBox_preco.Text
                        float preco = (float)Convert.ToDouble(row["Preço"]);
                        string titulo = row["Título"].ToString();
                        string imagemPath = row["imagem_url"].ToString();
                        int categoriaId = Convert.ToInt32(row["categoria_id"]);
                        int subcategoriaId = Convert.ToInt32(row["subcategoria_id"]);
                        string categoriaNome = row["categoria_nome"].ToString();
                        string subcategoriaNome = row["subcategoria_nome"].ToString();

                        txtBox_marca.Text = marca;
                        txtBox_preco.Text = preco.ToString();
                        txtBox_titulo.Text = titulo;
                        txtBox_imagemPath.Text = imagemPath;
                        comboBox_categoria.Text = categoriaNome;
                        comboBox_subcategoria.Text = subcategoriaNome;
                    }
                    else
                    {
                        MessageBox.Show("Product ID does not exist.");
                    }
                }
            }
        }





        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh_página();
        }

        private void refresh_página()
        {
            tabela_produtos();
            dgv_myCatalogo.Refresh();
            this.Refresh();
        }

        private void btn_confirmareliminar_Click(object sender, EventArgs e)
        {
            int idproduto = BuscarProdutoId();//bunifuMaterialTextbox1.; // ID

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                //string s = "select PF.AdicionarCliente(@Nome, @Endereço, @Nº_CC, @Género, @Email, @Nome_Empresa)";
                string s = "CHINSELL.EliminarProduto";
                SqlCommand cmd = new SqlCommand(s, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@produto_id ", idproduto);

                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produto eliminado com sucesso.");
                    txtbox_idproduto.Text = "";
                    btn_confirmareliminar.Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to edit product in database. \n ERROR MESSAGE: \n" + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }


        public int BuscarProdutoId()
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
                        //produtoId = Convert.ToInt32(text);
                        if (Int32.TryParse(txtbox_idproduto.Text, out produtoId))
                        {
                            if (IsIdPresentInDatabase(produtoId))
                            {
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@ProdutoId", produtoId);
                                return produtoId;
                            }
                            else
                                MessageBox.Show("Produto não existente");
                        }
                    }
                    while (true);
                }

            }
        }

        private void btn_eliminarproduto_Click(object sender, EventArgs e)
        {
            txtbox_idproduto.Text = "";
            lbl_idproduto.Visible = true;
            txtbox_idproduto.Visible = true;
            btn_idpesquisa.Visible = false;

            lbl_Título.Visible = false;
            lbl_preço.Visible = false;
            lbl_marca.Visible = false;
            lbl_categoria.Visible = false;
            lbl_subcategoria.Visible = false;

            txtBox_marca.Visible = false;
            txtBox_preco.Visible = false;
            txtBox_titulo.Visible = false;
            txtBox_imagemPath.Visible = false;

            comboBox_categoria.Visible = false;
            comboBox_subcategoria.Visible = false;

            btn_procurarimagem.Visible = false;
            btn_add.Visible = false;
            btn_editconfirm.Visible = false;
            btn_pesquisarideliminate.Visible = true;
        }

        private void btn_pesquisarideliminate_Click(object sender, EventArgs e)
        {
            string query = @"SELECT p.Marca, p.Preço, p.Título, p.imagem_url, p.categoria_id, p.subcategoria_id, c.Nome AS categoria_nome, s.Nome AS subcategoria_nome
                     FROM CHINSELL.PRODUTO p
                     INNER JOIN CHINSELL.CATEGORIA c ON p.categoria_id = c.categoria_id
                     INNER JOIN CHINSELL.SUBCATEGORIA s ON p.subcategoria_id = s.subcategoria_id
                     WHERE p.produto_id = @ProductID AND p.vendedor_id = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductID", txtbox_idproduto.Text);
                    command.Parameters.AddWithValue("@ID", ID);

                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Product ID exists");
                        btn_editconfirm.Visible = false;
                        DataRow row = dt.Rows[0];

                        //string marca = row["Marca"].ToString();
                        ////(float)Convert.ToDouble(txtBox_preco.Text
                        //float preco = (float)Convert.ToDouble(row["Preço"]);
                        //string titulo = row["Título"].ToString();
                        //string imagemPath = row["imagem_url"].ToString();
                        //int categoriaId = Convert.ToInt32(row["categoria_id"]);
                        //int subcategoriaId = Convert.ToInt32(row["subcategoria_id"]);
                        //string categoriaNome = row["categoria_nome"].ToString();
                        //string subcategoriaNome = row["subcategoria_nome"].ToString();

                        //txtBox_marca.Text = marca;
                        //txtBox_preco.Text = preco.ToString();
                        //txtBox_titulo.Text = titulo;
                        //txtBox_imagemPath.Text = imagemPath;
                        //comboBox_categoria.Text = categoriaNome;
                        //comboBox_subcategoria.Text = subcategoriaNome;

                        btn_editconfirm.Visible = false;
                        btn_confirmareliminar.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Product ID does not exist.");
                    }
                }
            }
        }
    }
}
