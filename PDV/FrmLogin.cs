using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV
{
    public partial class FrmLogin : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;
        string id;
        string nomeAntigo;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void chamarLogin()
        {
            if (txtUsuario.Text.Trim() == "" && txtSenha.Text.Trim() == "")
            {
                MessageBox.Show("Campos inválidos");
                return;
            }

            try
            {
                con.AbrirConexao();
                MySqlCommand cmdVerificar;
                MySqlDataReader reader; //com o reader vou conseguir extrair dados da tabela e usar em outros form
                cmdVerificar = new MySqlCommand("SELECT * FROM usuarios WHERE usuario = @usuario AND senha = @senha", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmdVerificar;
                cmdVerificar.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                cmdVerificar.Parameters.AddWithValue("@senha", txtSenha.Text);
                reader = cmdVerificar.ExecuteReader();
                if (reader.HasRows)
                {
                    //extraíndo dados do login
                    while (reader.Read())
                    {
                        Verificar.NomeUsuario = Convert.ToString(reader["usuario"]);
                        Verificar.CargoUsuario = Convert.ToString(Convert.ToString(reader["cargo"]));

                        FrmPrincipal pdv = new FrmPrincipal();
                        pdv.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha inválidos");
                    return;
                }
                con.FecharConexao();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            chamarLogin();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
