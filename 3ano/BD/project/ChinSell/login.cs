using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Bunifu.Framework.UI;

namespace ChinSell
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        private string userId;
        public Form1()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=tcp:mednat.ieeta.pt\SQLSERVER,8101;Initial Catalog=p2g4;Persist Security Info=True;User ID=p2g4;Password=bd.deti1602"; 
        }


        private void username_input_Enter(object sender, EventArgs e)
        {
            if (username_input.Text.Equals(@"Username"))
            {
                username_input.Text = "";
            }
        }

        private void username_input_Leave(object sender, EventArgs e)
        {
            if (username_input.Text.Equals(""))
            {
                username_input.Text = "Username";
            }
        }

        private void password_input_Enter(object sender, EventArgs e)
        {
            if (password_input.Text.Equals("Password"))
            {
                password_input.Text = "";
            }
        }

        private void password_input_Leave(object sender, EventArgs e)
        {
            if (password_input.Text.Equals(""))
            {
                password_input.Text = "Password";
            }
        }

        private void BTN_LOGIN_Click(object sender, EventArgs e)
        {
            string email = username_input.Text;
            string senha = password_input.Text;

            bool loginSucesso = FazerLogin(email, senha);

            if (loginSucesso)
            {
                MessageBox.Show("Login realizado com sucesso!","Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                catálogo form2 = new catálogo();
                form2.ReceberUserId(userId);
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Erro no login", "Verifique se os seus dados estão corretos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool FazerLogin(string email, string senha)
        {

            using (SqlConnection connection = new SqlConnection(con.ConnectionString))
            {
                connection.Open();

                // UDF implementada
                SqlCommand cmdVerificarEmail = new SqlCommand("SELECT CHINSELL.VerificarEmail(@Email)", connection);
                cmdVerificarEmail.Parameters.AddWithValue("@Email", email);
                int emailExistente = Convert.ToInt32(cmdVerificarEmail.ExecuteScalar());


                if (emailExistente > 0)
                {
                    // Verificar se a senha está correta
                    SqlCommand cmdVerificarSenha = new SqlCommand("SELECT CHINSELL.VerificarPass(@Pass)", connection);
                    cmdVerificarSenha.Parameters.AddWithValue("@Pass", senha);
                    int senhaCorreta = Convert.ToInt32(cmdVerificarSenha.ExecuteScalar());

                    if (senhaCorreta > 0)
                    {
                        // Email e senha estão corretos, login bem-sucedido
                        userId = GetUserIdFromCredentials(username_input.Text, password_input.Text);
                        return true;
                    }
                }
            }

            // Email ou senha incorretos, falha no login
            return false;
        }

        private string GetUserIdFromCredentials(string email, string password)
        {
            string userId = null;
            string query = "SELECT id FROM CHINSELL.UTILIZADOR WHERE Email = @Email AND Pass = @Password";

            using (SqlConnection connection = new SqlConnection(@"Data Source=tcp:mednat.ieeta.pt\SQLSERVER,8101;Initial Catalog=p2g4;Persist Security Info=True;User ID=p2g4;Password=bd.deti1602"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        userId = result.ToString();
                    }
                }
            }

            return userId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            catálogo form2 = new catálogo();
            form2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
