using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PDV.cadastros
{
    public partial class FrmCargo : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;
        string id;
        string nomeAntigo;


        public FrmCargo()
        {
            InitializeComponent();
        }

        private void FrmCargo_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void FormatarGD()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Cargos";
            grid.Columns[2].HeaderText = "Data";
            grid.Columns[0].Visible = false;

            // Definir a propriedade AutoSizeMode como Fill nas colunas 1 e 2
            grid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Definir a propriedade ReadOnly como true nas colunas 0 e 2
            grid.Columns[1].ReadOnly = true;
            grid.Columns[2].ReadOnly = true;
        }

        private void Listar()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM cargos ORDER BY cargo asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharConexao();

            FormatarGD();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Deseja realmente excluir o registro!", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                con.AbrirConexao();
                sql = "DELETE FROM cargos WHERE id = @id";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.FecharConexao();

                Listar();

                MessageBox.Show("Registro Excluído com sucesso!", "Cadastro Cargos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Enabled = true;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Nome.Text) || !System.Text.RegularExpressions.Regex.IsMatch(txt_Nome.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Preencha o campo nome", "Cadastro de Cargos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Nome.Text = "";
                txt_Nome.Focus();
                return;
            }

            con.AbrirConexao();

            // Verificar se o cargo já existe no banco de dados
            string cargoExistenteQuery = "SELECT COUNT(*) FROM cargos WHERE cargo = @cargo";
            MySqlCommand cargoExistenteCmd = new MySqlCommand(cargoExistenteQuery, con.con);
            cargoExistenteCmd.Parameters.AddWithValue("@cargo", txt_Nome.Text);
            int cargoExistenteCount = Convert.ToInt32(cargoExistenteCmd.ExecuteScalar());

            if (cargoExistenteCount > 0)
            {
                MessageBox.Show("O Cargo " + txt_Nome.Text + " já está registrado", "Cadastro de Cargos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                con.FecharConexao();
                return;
            }

            // Inserir o cargo caso não exista
            sql = "INSERT INTO cargos(cargo, data) VALUES(@cargo, curDate())";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@cargo", txt_Nome.Text);
            cmd.ExecuteNonQuery();

            con.FecharConexao();
            Listar();

            MessageBox.Show("Registro Salvo com sucesso!", "Cadastro cargos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;

            txt_Nome.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txt_Nome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo nome", "Cadastro funcionários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Nome.Text = "";
                txt_Nome.Focus();
                return;
            }

            con.AbrirConexao();

            // Verificar se o cargo já existe
            if (txt_Nome.Text != nomeAntigo)
            {
                MySqlCommand cmdVerificar;
                cmdVerificar = new MySqlCommand("SELECT * FROM cargos WHERE cargo = @cargo", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmdVerificar;
                cmdVerificar.Parameters.AddWithValue("@cargo", txt_Nome.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("O Cargo " + txt_Nome.Text + " já está cadastrado", "Cadastro de Cargos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txt_Nome.Text = "";
                    txt_Nome.Focus();
                    con.FecharConexao();
                    return;
                }
            }

            // Atualizar o cargo
            sql = "UPDATE cargos SET cargo = @cargo, data = curDate() WHERE id = @id";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@cargo", txt_Nome.Text);
            cmd.ExecuteNonQuery();

            con.FecharConexao();
            Listar();

            MessageBox.Show("Registro do cargo " + "Editado com sucesso!", "Cadastro de Cargos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            txt_Nome.Enabled = true;
            btnSalvar.Enabled = true;
            txt_Nome.Focus();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnSalvar.Enabled = false;
                btnNovo.Enabled = false;
                txt_Nome.Enabled = true;


                id = grid.CurrentRow.Cells[0].Value.ToString();
                txt_Nome.Text = grid.CurrentRow.Cells[1].Value.ToString();
            }

        }
    }
}
