using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PDV.cadastros
{
    public partial class FrmClientes : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;

        string id;
        string cpfAntigo;
        string foto;
        string alterouImagem = "nao";
        //mensagem do RadioButton ao adicionar ou editar
        string radButton = "";
        //ao selecionar na grid mostra o radioButton
        string desbloqueado, inadiplente;
        bool emailAdress = false;

        int codCliente, IdAnterior;

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

        }

        private void FormatarGD()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Código";
            grid.Columns[2].HeaderText = "Nome";
            grid.Columns[3].HeaderText = "Cpf";
            grid.Columns[4].HeaderText = "Em Aberto";
            grid.Columns[5].HeaderText = "Telefone";
            grid.Columns[6].HeaderText = "Email";
            grid.Columns[7].HeaderText = "Desbloqueado";
            grid.Columns[8].HeaderText = "Status";
            grid.Columns[9].HeaderText = "Endereço";
            grid.Columns[10].HeaderText = "Funcionário";
            grid.Columns[11].HeaderText = "img";
            grid.Columns[12].HeaderText = "Data";
            //grid.Columns[0].Width = 50;
            grid.Columns[0].Visible = false;
            grid.Columns[11].Visible = false;
            grid.Columns[4].DefaultCellStyle.Format = "c2";

        }

        private void Listar()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM cliente ORDER BY nome asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharConexao();

            FormatarGD();
        }

        private void BuscarNome()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM clientes WHERE nome LIKE @nome ORDER BY nome asc"; //LIKE, busca nome por aproximação
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txtBuscarNome.Text + "%"); //"%" - operador LIKE, busca nome por aproximacao
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharConexao();

            FormatarGD();
        }

        private void BuscarCpf()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM clientes WHERE cpf=@cpf ORDER BY nome asc";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@cpf", txtBuscarCpf.Text);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharConexao();
            FormatarGD();
        }

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtCpf.Enabled = true;
            txtEndereco.Enabled = true;
            txtTelefone.Enabled = true;
            txtEmail.Enabled = true;
            cbInadiplente.Enabled = true;
            txtValorAberto.Enabled = true;
            txtNome.Focus();
        }

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtCpf.Enabled = false;
            txtEndereco.Enabled = false;
            txtTelefone.Enabled = false;
            txtEmail.Enabled = false;
            cbInadiplente.Enabled = false;
            txtValorAberto.Enabled = false;
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtCpf.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            cbInadiplente.SelectedIndex = 0;
        }

        private void Status()
        {
            //radButton = grupoBox.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            LimparCampos();
            LimparFoto();
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnImg.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void verificarEmail()
        {
            string email = txtEmail.Text;

            Regex rg = new Regex(@"^");

            if (rg.IsMatch(email))
            {
                emailAdress = true;
                btnSalvar.Enabled = true;
                imgEmail.Image = Properties.Resources.OK;
            }
            else
            {
                emailAdress = false;
                btnSalvar.Enabled = false;
                imgEmail.Image = Properties.Resources.ocupado;
            }
        }
        private void ultimoIdCliente()
        {
            //recuperar ultimo id da reserva
            con.AbrirConexao();
            MySqlCommand cmdVerificar;
            MySqlDataReader reader; //com o reader vou conseguir extrair dados da tabela e usar em outras form
            cmdVerificar = new MySqlCommand("SELECT id FROM clientes ORDER BY id DESC LIMIT 1", con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmdVerificar;
            reader = cmdVerificar.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    IdAnterior = Convert.ToInt32(reader["id"]);
                    codCliente = IdAnterior + 1;
                }
            }
        }
        private byte[] img() //este metodo é padrao, serve sempre q deseja enviar uma imagem para o banco de dados
        {
            byte[] imagem_byte = null;
            if(foto == "")
            {
                return null;
            }
            FileStream fs = new FileStream(foto, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            imagem_byte = br.ReadBytes((int)fs.Length);
            return imagem_byte;
        }
        private void LimparFoto()
        {
            image.Image = Properties.Resources.perfil;
            foto = "img/perfil.png";
        }
    }
}
