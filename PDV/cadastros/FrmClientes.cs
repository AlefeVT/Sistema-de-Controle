using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PDV.cadastros
{
    public partial class FrmClientes : Form
    {
        // Variáveis relacionadas ao banco de dados
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;

        // Variáveis do formulário
        string id;
        string cpfAntigo;
        string foto;
        string alterouImagem = "nao"; // Verifica se a imagem do perfil foi alterada
        string radButton = ""; // Valor do botão de rádio selecionado
        string desbloqueado, inadiplente; // Variáveis de status
        bool emailAdress = false; // Verifica se o endereço de email é válido

        int codCliente, IdAnterior;

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            LimparFoto();
            Listar(); // Carrega os dados na tabela DataGridView
            alterouImagem = "não";
        }

        // Formatar colunas do DataGridView (grid)
        private void FormatarGD()
        {
            // Definir cabeçalhos para as colunas
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Codigo";
            grid.Columns[2].HeaderText = "Nome";
            grid.Columns[3].HeaderText = "CPF";
            grid.Columns[4].HeaderText = "Valor Aberto";
            grid.Columns[5].HeaderText = "Tel";
            grid.Columns[6].HeaderText = "Email";
            grid.Columns[7].HeaderText = "Status";
            grid.Columns[8].HeaderText = "Inadiplente";
            grid.Columns[9].HeaderText = "Endereço";
            grid.Columns[10].HeaderText = "Foto";
            grid.Columns[11].HeaderText = "Data";

            //... (outros cabeçalhos das colunas)

            // Definir a visibilidade das colunas
            grid.Columns[0].Visible = false;
            grid.Columns[10].Visible = false;

            // Definir formatação para colunas específicas
            grid.Columns[4].DefaultCellStyle.Format = "c2"; // Formato de moeda (c2)
        }

        // Carregar dados na tabela DataGridView (grid)
        private void Listar()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM clientes ORDER BY nome ASC";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharConexao();

            FormatarGD();
        }

        // Buscar clientes pelo nome
        private void BuscarNome()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM clientes WHERE nome LIKE @nome ORDER BY nome ASC";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txtBuscarNome.Text + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharConexao();

            FormatarGD();
        }

        // Buscar clientes pelo CPF
        private void BuscarCpf()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM clientes WHERE cpf=@cpf ORDER BY nome ASC";
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

        // Habilitar a edição das informações do cliente
        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            //... (outros campos)
            txtNome.Focus();
        }

        // Desabilitar a edição das informações do cliente
        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            //... (outros campos)
        }

        // Limpar os campos de informações do cliente
        private void LimparCampos()
        {
            txtNome.Text = "";
            //... (outros campos)
        }

        // Obter o status selecionado (botão de rádio) do formulário
        private void Status()
        {
            //radButton = grupoBox.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
        }

        // Lidar com o evento de clique do botão "Novo"
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

        // Lidar com o evento de clique do botão "Salvar"
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Verificar se os campos contêm dados válidos
            if (string.IsNullOrWhiteSpace(txtNome.Text) || !Regex.IsMatch(txtNome.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Preencha o campo nome", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            //... (outras validações dos campos)
        }

        // Lidar com o evento de clique do botão "Cancelar"
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            DesabilitarCampos();
            LimparCampos();
        }

        // Lidar com o evento de clique do botão "Editar"
        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            DesabilitarCampos();
            LimparCampos();
            LimparFoto();
            alterouImagem = "não";
        }

        // Lidar com o evento de clique do botão "Excluir"
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Deseja realmente excluir o registro!", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                con.AbrirConexao();
                sql = "DELETE FROM clientes WHERE id = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                int rowsAffected = cmd.ExecuteNonQuery();
                con.FecharConexao();
            }

            MessageBox.Show("Registro Excluído com sucesso!", "Cadastro clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            DesabilitarCampos();
            LimparCampos();
            LimparFoto();
            Listar();
        }

        // Validar o endereço de email
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

        // Obter o último ID de cliente do banco de dados
        private void ultimoIdCliente()
        {
            con.AbrirConexao();
            MySqlCommand cmdVerificar;
            MySqlDataReader reader;
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

        // Converter imagem em matriz de bytes (se disponível)
        private byte[] img()
        {
            byte[] imagem_byte = null;
            if (foto == "")
            {
                return null;
            }
            FileStream fs = new FileStream(foto, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            imagem_byte = br.ReadBytes((int)fs.Length);
            return imagem_byte;
        }

        // Limpar a foto de perfil do cliente
        private void LimparFoto()
        {
            image.Image = Properties.Resources.perfil;
            foto = "img/perfil.png";
        }
    }
}
