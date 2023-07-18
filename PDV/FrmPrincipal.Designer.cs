
namespace PDV
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barraStatus = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.statusData = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.statusHora = new System.Windows.Forms.ToolStripLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMinimiza = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.btnCargos = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnMovimentacao = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.lblUsuario = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.lblCargo = new System.Windows.Forms.ToolStripLabel();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.menuPrincipal.SuspendLayout();
            this.barraStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.panelMenu.Controls.Add(this.btnCargos);
            this.panelMenu.Controls.Add(this.btnRelatorios);
            this.panelMenu.Controls.Add(this.btnCaixa);
            this.panelMenu.Controls.Add(this.btnMovimentacao);
            this.panelMenu.Controls.Add(this.btnClientes);
            this.panelMenu.Controls.Add(this.btnFuncionarios);
            this.panelMenu.Controls.Add(this.btnProdutos);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(212, 618);
            this.panelMenu.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.panelTitleBar.Controls.Add(this.btnMaximizar);
            this.panelTitleBar.Controls.Add(this.btnFechar);
            this.panelTitleBar.Controls.Add(this.btnMinimiza);
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(212, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(870, 84);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(383, 29);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(78, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.barraStatus);
            this.panelDesktop.Controls.Add(this.menuPrincipal);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(212, 84);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(870, 534);
            this.panelDesktop.TabIndex = 2;
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(870, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // barraStatus
            // 
            this.barraStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barraStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.statusData,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.statusHora,
            this.toolStripSeparator3,
            this.toolStripLabel3,
            this.lblUsuario,
            this.toolStripSeparator4,
            this.toolStripLabel5,
            this.lblCargo});
            this.barraStatus.Location = new System.Drawing.Point(0, 509);
            this.barraStatus.Name = "barraStatus";
            this.barraStatus.Size = new System.Drawing.Size(870, 25);
            this.barraStatus.TabIndex = 2;
            this.barraStatus.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel1.Text = "Data: ";
            // 
            // statusData
            // 
            this.statusData.Name = "statusData";
            this.statusData.Size = new System.Drawing.Size(65, 22);
            this.statusData.Text = "00/00/0000";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(39, 22);
            this.toolStripLabel2.Text = "Hora: ";
            // 
            // statusHora
            // 
            this.statusHora.Name = "statusHora";
            this.statusHora.Size = new System.Drawing.Size(34, 22);
            this.statusHora.Text = "00:00";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = global::PDV.Properties.Resources.maximize;
            this.btnMaximizar.Location = new System.Drawing.Point(781, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(40, 23);
            this.btnMaximizar.TabIndex = 4;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = global::PDV.Properties.Resources.close;
            this.btnFechar.Location = new System.Drawing.Point(827, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 23);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnMinimiza
            // 
            this.btnMinimiza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimiza.FlatAppearance.BorderSize = 0;
            this.btnMinimiza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimiza.Image = global::PDV.Properties.Resources.minimize;
            this.btnMinimiza.Location = new System.Drawing.Point(752, -9);
            this.btnMinimiza.Name = "btnMinimiza";
            this.btnMinimiza.Size = new System.Drawing.Size(21, 39);
            this.btnMinimiza.TabIndex = 2;
            this.btnMinimiza.UseVisualStyleBackColor = true;
            this.btnMinimiza.Click += new System.EventHandler(this.btnMinimiza_Click);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = global::PDV.Properties.Resources._return;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(39, 84);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // btnCargos
            // 
            this.btnCargos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCargos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCargos.Image = global::PDV.Properties.Resources.Relatorios;
            this.btnCargos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargos.Location = new System.Drawing.Point(0, 432);
            this.btnCargos.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargos.Name = "btnCargos";
            this.btnCargos.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnCargos.Size = new System.Drawing.Size(212, 58);
            this.btnCargos.TabIndex = 8;
            this.btnCargos.Text = "   Cargos";
            this.btnCargos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCargos.UseVisualStyleBackColor = true;
            this.btnCargos.Click += new System.EventHandler(this.btnCargos_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRelatorios.Image = global::PDV.Properties.Resources.Relatorios;
            this.btnRelatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorios.Location = new System.Drawing.Point(0, 374);
            this.btnRelatorios.Margin = new System.Windows.Forms.Padding(2);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnRelatorios.Size = new System.Drawing.Size(212, 58);
            this.btnRelatorios.TabIndex = 7;
            this.btnRelatorios.Text = "   Relatórios";
            this.btnRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnCaixa
            // 
            this.btnCaixa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaixa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCaixa.Image = global::PDV.Properties.Resources.pc;
            this.btnCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaixa.Location = new System.Drawing.Point(0, 316);
            this.btnCaixa.Margin = new System.Windows.Forms.Padding(2);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnCaixa.Size = new System.Drawing.Size(212, 58);
            this.btnCaixa.TabIndex = 6;
            this.btnCaixa.Text = "   Caixa";
            this.btnCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCaixa.UseVisualStyleBackColor = true;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // btnMovimentacao
            // 
            this.btnMovimentacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMovimentacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovimentacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimentacao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMovimentacao.Image = global::PDV.Properties.Resources.movimentacao;
            this.btnMovimentacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovimentacao.Location = new System.Drawing.Point(0, 258);
            this.btnMovimentacao.Margin = new System.Windows.Forms.Padding(2);
            this.btnMovimentacao.Name = "btnMovimentacao";
            this.btnMovimentacao.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnMovimentacao.Size = new System.Drawing.Size(212, 58);
            this.btnMovimentacao.TabIndex = 5;
            this.btnMovimentacao.Text = "   Movimentação";
            this.btnMovimentacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovimentacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMovimentacao.UseVisualStyleBackColor = true;
            this.btnMovimentacao.Click += new System.EventHandler(this.btnMovimentacoes_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClientes.Image = global::PDV.Properties.Resources.Clientes;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 200);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(212, 58);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "   Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFuncionarios.Image = global::PDV.Properties.Resources.Users;
            this.btnFuncionarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionarios.Location = new System.Drawing.Point(0, 142);
            this.btnFuncionarios.Margin = new System.Windows.Forms.Padding(2);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnFuncionarios.Size = new System.Drawing.Size(212, 58);
            this.btnFuncionarios.TabIndex = 3;
            this.btnFuncionarios.Text = "   Funcionários";
            this.btnFuncionarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFuncionarios.UseVisualStyleBackColor = true;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProdutos.Image = global::PDV.Properties.Resources.carrin1;
            this.btnProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdutos.Location = new System.Drawing.Point(0, 84);
            this.btnProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnProdutos.Size = new System.Drawing.Size(212, 58);
            this.btnProdutos.TabIndex = 2;
            this.btnProdutos.Text = "   Produtos";
            this.btnProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = global::PDV.Properties.Resources.Logo;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(212, 84);
            this.panelLogo.TabIndex = 2;
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel3.Text = "Usuário: ";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(38, 22);
            this.lblUsuario.Text = "nome";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabel5.Text = "Cargo: ";
            // 
            // lblCargo
            // 
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(37, 22);
            this.lblCargo.Text = "cargo";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1082, 618);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1054, 657);
            this.Name = "FrmPrincipal";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.barraStatus.ResumeLayout(false);
            this.barraStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnMovimentacao;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMinimiza;
        private System.Windows.Forms.Button btnCargos;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStrip barraStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel statusData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel statusHora;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel lblUsuario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel lblCargo;
    }
}

