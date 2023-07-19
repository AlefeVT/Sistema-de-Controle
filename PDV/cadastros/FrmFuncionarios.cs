using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PDV.cadastros
{
    public partial class FrmFuncionarios : Form
    {
        // Conexão com o banco de dados e outras variáveis
        private Conexao con = new Conexao();
        private string sql;
        private MySqlCommand cmd;
        private string id;
        private string foto;
        private string alterouImagem = "não";
        private string cpfAntigo;

        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        // Evento de carregamento do formulário
        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            // Limpar a foto do funcionário
            LimparFoto();
            // Listar funcionários
            Listar();
            // Listar os cargos disponíveis
            ListarCargos();
            alterouImagem = "não";
            cb_Cargo.Text = "Selecione um Cargo";
        }

        // Recuperar e listar os funcionários
        private void Listar()
        {
            // Abrir conexão com o banco de dados
            con.AbrirConexao();
            sql = "SELECT * FROM funcionarios ORDER BY nome ASC";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharConexao();

            // Formatar a grade de dados
            FormatarGD();
        }

        // Listar os cargos disponíveis
        private void ListarCargos()
        {
            // Abrir conexão com o banco de dados
            con.AbrirConexao();
            sql = "SELECT * FROM cargos ORDER BY cargo ASC";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_Cargo.DataSource = dt;
            cb_Cargo.DisplayMember = "cargo";
            con.FecharConexao();
        }

        // Formatar a grade de dados
        private void FormatarGD()
        {
            // Cabeçalhos das colunas
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Colaborador";
            grid.Columns[2].HeaderText = "CPF";
            grid.Columns[3].HeaderText = "Tel";
            grid.Columns[4].HeaderText = "Cargo";
            grid.Columns[5].HeaderText = "Endereço";
            grid.Columns[6].HeaderText = "Data";
            grid.Columns[7].HeaderText = "Foto";

            // Ocultar colunas desnecessárias
            grid.Columns[0].Visible = false;
            grid.Columns[7].Visible = false;

            // Definir a propriedade AutoSizeMode como Fill nas colunas 1, 2, 3, 4 e 5
            grid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Definir a propriedade ReadOnly como true nas colunas 0, 2, 3, 5 e 7
            grid.Columns[1].ReadOnly = true;
            grid.Columns[2].ReadOnly = true;
            grid.Columns[3].ReadOnly = true;
            grid.Columns[4].ReadOnly = true;
            grid.Columns[5].ReadOnly = true;
            grid.Columns[6].ReadOnly = true;
        }

        // Salvar dados do funcionário
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Verificar campos obrigatórios e validações
            if (string.IsNullOrWhiteSpace(txt_Nome.Text) || !System.Text.RegularExpressions.Regex.IsMatch(txt_Nome.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Preencha o campo nome", "Cadastro funcionários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Nome.Text = "";
                txt_Nome.Focus();
                return;
            }

            if (txt_Cpf.Text == "   ,   ,   -" || txt_Cpf.Text.Length < 14)
            {
                MessageBox.Show("Preencha o campo CPF", "Cadastro duncionários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Cpf.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cb_Cargo.Text) || cb_Cargo.Text.Equals("Selecione um Cargo"))
            {
                MessageBox.Show("Selecione um cargo", "Cadastro funcionários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_Cargo.Focus();
                return;
            }

            // Inserir dados do funcionário no banco de dados
            con.AbrirConexao();
            sql = "INSERT INTO funcionarios(nome, cpf, telefone, cargo, endereco, data, foto) VALUES(@nome, @cpf, @telefone, @cargo, @endereco, curDate(), @foto)";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txt_Nome.Text);
            cmd.Parameters.AddWithValue("@cpf", txt_Cpf.Text);
            cmd.Parameters.AddWithValue("@telefone", txt_Telefone.Text);
            cmd.Parameters.AddWithValue("@cargo", cb_Cargo.Text);
            cmd.Parameters.AddWithValue("@endereco", txt_Endereco.Text);
            cmd.Parameters.AddWithValue("@foto", img());
            cmd.ExecuteNonQuery();
            con.FecharConexao();

            LimparFoto();

            MessageBox.Show("Registro Salvo com sucesso!", "Cadastro funcionários", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnFoto.Enabled = false;
            LimparCampos();
            Listar();
            DesabilitarCampos();
        }

        // Desabilitar campos de entrada
        private void DesabilitarCampos()
        {
            txt_Nome.Enabled = false;
            txt_Cpf.Enabled = false;
            txt_Endereco.Enabled = false;
            txt_Telefone.Enabled = false;
            cb_Cargo.Enabled = false;
        }

        // Selecionar uma foto para o funcionário
        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens(*.jpg; *.png) | *.jpg;*.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foto = dialog.FileName.ToString();
                image.ImageLocation = foto;
                alterouImagem = "sim";
            }
        }

        // Converter foto para um array de bytes
        private byte[] img()
        {
            byte[] image_byte = null;
            if (foto == "")
            {
                return null;
            }

            FileStream fs = new FileStream(foto, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            image_byte = br.ReadBytes((int)fs.Length);
            return image_byte;
        }

        // Limpar a foto
        private void LimparFoto()
        {
            image.Image = Properties.Resources.perfil;
            foto = "Resources/sem_foto.png";
        }

        // Habilitar campos de entrada para adicionar um novo funcionário
        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            LimparCampos();
            txt_Nome.Focus();
        }

        // Habilitar campos de entrada
        private void HabilitarCampos()
        {
            btnSalvar.Enabled = true;
            txt_Nome.Enabled = true;
            txt_Cpf.Enabled = true;
            txt_Endereco.Enabled = true;
            txt_Telefone.Enabled = true;
            cb_Cargo.Enabled = true;
            btnFoto.Enabled = true;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
        }

        // Limpar campos de entrada
        private void LimparCampos()
        {
            txt_Nome.Text = "";
            txt_Cpf.Text = "";
            txt_Endereco.Text = "";
            txt_Telefone.Text = "";
        }

        // Evento de clique na grade de dados para selecionar uma linha e carregar os dados do funcionário nos campos de entrada
        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                HabilitarCampos();
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnSalvar.Enabled = false;
                btnNovo.Enabled = false;

                id = grid.CurrentRow.Cells[0].Value.ToString();
                txt_Nome.Text = grid.CurrentRow.Cells[1].Value.ToString();
                txt_Cpf.Text = grid.CurrentRow.Cells[2].Value.ToString();
                cpfAntigo = grid.CurrentRow.Cells[2].Value.ToString();
                txt_Telefone.Text = grid.CurrentRow.Cells[3].Value.ToString();
                cb_Cargo.Text = grid.CurrentRow.Cells[4].Value.ToString();
                txt_Endereco.Text = grid.CurrentRow.Cells[5].Value.ToString();

                if (grid.CurrentRow.Cells[7].Value != DBNull.Value) //DBNull.Value campo quem do Banco de dados
                {
                    byte[] imagem = (byte[])grid.Rows[e.RowIndex].Cells[7].Value; //criada var byte[] imagem p/ receber convertido em byte[] o que vem da grid
                    MemoryStream ms = new MemoryStream(imagem); //recebe a var byte[] q já contem o valor da grid (decodificado / convertido)

                    //o componente 'Image' sempre pede um 'System.Drawing' entao...
                    image.Image = Image.FromStream(ms); //passando o memorystream no objeto q ele recebe um System.Drawing e seu parametro FromStream()
                }
                else
                {
                    image.Image = Properties.Resources.sem_foto; //aqui coloca a imagem perfil do funcionario na picture do form
                }
            }
            else
            {
                return;
            }
        }

        // Cancelar a edição ou adição de um novo funcionário
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            DesabilitarCampos();
            LimparCampos();
        }

        // Editar dados do funcionário
        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verificar campos obrigatórios e validações
            if (txt_Nome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo nome", "Cadastro funcionários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Nome.Text = "";
                txt_Nome.Focus();
                return;
            }
            if (txt_Cpf.Text == "   .   .   -" || txt_Cpf.TextLength < 14)
            {
                MessageBox.Show("Preencha o campo CPF", "Cadastro funcionários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Cpf.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cb_Cargo.Text) || cb_Cargo.Text.Equals("Selecione um Cargo"))
            {
                MessageBox.Show("Selecione um Cargo", "Cadastro funcionários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_Cargo.Focus();
                return;
            }

            // Atualizar os dados do funcionário no banco de dados
            con.AbrirConexao();
            if (alterouImagem == "sim")
            {
                sql = "UPDATE funcionarios SET nome = @nome, cpf = @cpf, endereco = @endereco, telefone = @telefone, cargo = @cargo, foto = @foto WHERE id = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id); //Where
                cmd.Parameters.AddWithValue("@nome", txt_Nome.Text);
                cmd.Parameters.AddWithValue("@cpf", txt_Cpf.Text);
                cmd.Parameters.AddWithValue("@endereco", txt_Endereco.Text);
                cmd.Parameters.AddWithValue("@telefone", txt_Telefone.Text);
                cmd.Parameters.AddWithValue("@cargo", cb_Cargo.Text);
                cmd.Parameters.AddWithValue("@foto", img());
            }
            else if (alterouImagem == "não")
            {
                sql = "UPDATE funcionarios SET nome = @nome, cpf = @cpf, endereco = @endereco, telefone = @telefone, cargo = @cargo WHERE id = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nome", txt_Nome.Text);
                cmd.Parameters.AddWithValue("@cpf", txt_Cpf.Text);
                cmd.Parameters.AddWithValue("@endereco", txt_Endereco.Text);
                cmd.Parameters.AddWithValue("@telefone", txt_Telefone.Text);
                cmd.Parameters.AddWithValue("@cargo", cb_Cargo.Text);
            }

            // Verificar se o novo CPF já existe
            if (txt_Cpf.Text != cpfAntigo)
            {
                MySqlCommand cmdVerificar;
                cmdVerificar = new MySqlCommand("SELECT * FROM funcionarios WHERE cpf = @cpf", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmdVerificar;
                cmdVerificar.Parameters.AddWithValue("@cpf", txt_Cpf.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("CPF já registrado", "Cadastro de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txt_Cpf.Text = "";
                    txt_Cpf.Focus();
                    return;
                }
            }
            cmd.ExecuteNonQuery();
            con.FecharConexao();
            Listar();

            MessageBox.Show("Registro Editado com sucesso!", "Cadastro funcionários", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            DesabilitarCampos();
            LimparCampos();
            LimparFoto();
            alterouImagem = "não"; //p/ uso de editar imagem
        }

        // Excluir dados do funcionário
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Deseja realmente excluir o registro!", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                con.AbrirConexao();
                sql = "DELETE FROM funcionarios WHERE id = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                int rowsAffected = cmd.ExecuteNonQuery();
                con.FecharConexao();
            }

            MessageBox.Show("Registro Excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            DesabilitarCampos();
            LimparCampos();
            LimparFoto();
            Listar();
        }

        // Selecionar uma foto para o funcionário (outro botão de foto)
        private void btnFoto_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens(*.jpg; *.png) | *.jpg;*.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foto = dialog.FileName; // Obter o caminho completo do arquivo selecionado
                image.ImageLocation = foto; // Exibir a imagem no PictureBox
                alterouImagem = "sim";
            }
        }

    }
}
