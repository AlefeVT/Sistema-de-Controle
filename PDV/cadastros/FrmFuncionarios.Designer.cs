
namespace PDV.cadastros
{
    partial class FrmFuncionarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txt_Endereco = new System.Windows.Forms.MaskedTextBox();
            this.txt_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.txt_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.cb_Cargo = new System.Windows.Forms.ComboBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.image = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AccessibleName = "";
            this.grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(67)))), ((int)(((byte)(92)))));
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(13, 208);
            this.grid.Margin = new System.Windows.Forms.Padding(2);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 51;
            this.grid.RowTemplate.Height = 24;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(831, 219);
            this.grid.TabIndex = 47;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(268, 453);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 31);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txt_Endereco
            // 
            this.txt_Endereco.Enabled = false;
            this.txt_Endereco.Location = new System.Drawing.Point(74, 94);
            this.txt_Endereco.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Endereco.Name = "txt_Endereco";
            this.txt_Endereco.Size = new System.Drawing.Size(395, 20);
            this.txt_Endereco.TabIndex = 35;
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Enabled = false;
            this.txt_Telefone.Location = new System.Drawing.Point(74, 62);
            this.txt_Telefone.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Telefone.Mask = "(99) 00000-0000";
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(79, 20);
            this.txt_Telefone.TabIndex = 33;
            // 
            // txt_Cpf
            // 
            this.txt_Cpf.Enabled = false;
            this.txt_Cpf.Location = new System.Drawing.Point(553, 27);
            this.txt_Cpf.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Cpf.Mask = "000.000.000-00";
            this.txt_Cpf.Name = "txt_Cpf";
            this.txt_Cpf.Size = new System.Drawing.Size(79, 20);
            this.txt_Cpf.TabIndex = 32;
            // 
            // btnFoto
            // 
            this.btnFoto.Enabled = false;
            this.btnFoto.Location = new System.Drawing.Point(733, 155);
            this.btnFoto.Margin = new System.Windows.Forms.Padding(2);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(76, 31);
            this.btnFoto.TabIndex = 36;
            this.btnFoto.Text = "Buscar foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click_1);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(512, 453);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(88, 31);
            this.btnExcluir.TabIndex = 45;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(391, 453);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(88, 31);
            this.btnEditar.TabIndex = 44;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(136, 453);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(88, 31);
            this.btnSalvar.TabIndex = 40;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(13, 453);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(88, 31);
            this.btnNovo.TabIndex = 39;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // cb_Cargo
            // 
            this.cb_Cargo.Enabled = false;
            this.cb_Cargo.FormattingEnabled = true;
            this.cb_Cargo.Location = new System.Drawing.Point(553, 63);
            this.cb_Cargo.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Cargo.Name = "cb_Cargo";
            this.cb_Cargo.Size = new System.Drawing.Size(121, 21);
            this.cb_Cargo.TabIndex = 34;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Enabled = false;
            this.txt_Nome.Location = new System.Drawing.Point(74, 27);
            this.txt_Nome.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(395, 20);
            this.txt_Nome.TabIndex = 30;
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.image.Image = global::PDV.Properties.Resources.sem_foto;
            this.image.Location = new System.Drawing.Point(708, 11);
            this.image.Margin = new System.Windows.Forms.Padding(2);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(136, 140);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 46;
            this.image.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(10, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(11, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Endereço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(497, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Cargo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(497, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nome";
            // 
            // FrmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(854, 495);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txt_Endereco);
            this.Controls.Add(this.txt_Telefone);
            this.Controls.Add(this.txt_Cpf);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.cb_Cargo);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.image);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "FrmFuncionarios";
            this.Text = "Funcionarios";
            this.Load += new System.EventHandler(this.FrmFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.MaskedTextBox txt_Endereco;
        private System.Windows.Forms.MaskedTextBox txt_Telefone;
        private System.Windows.Forms.MaskedTextBox txt_Cpf;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ComboBox cb_Cargo;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}