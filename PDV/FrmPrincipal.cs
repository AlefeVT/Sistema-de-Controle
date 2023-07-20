using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV
{
    public partial class FrmPrincipal : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //Construtor
        public FrmPrincipal()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            //this.Text = string.Empty;
            //this.ControlBox = false;

            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        //metodo p/ Selecionar uma cor aleatoria p/ o tema da lista de cores (pode usar uma cor se quiser)
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void openChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
            btnCloseChildForm.Visible = true;
        }

        private void btnCadastroProduto_Click(object sender, EventArgs e)
        {
            openChildForm(new cadastros.FrmProdutos(), sender);
            menuPrincipal.Visible = false;
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            openChildForm(new cadastros.FrmFuncionarios(), sender);
            menuPrincipal.Visible = false;
        }
        private void btnCadastroCategoria_Click(object sender, EventArgs e)
        {
            openChildForm(new cadastros.FrmCategorias(), sender);
            menuPrincipal.Visible = false;
        }
        private void btnCadastroCargo_Click(object sender, EventArgs e)
        {
            openChildForm(new cadastros.FrmCargo(), sender);
            menuPrincipal.Visible = false;
        }

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            openChildForm(new cadastros.FrmClientes(), sender);
            menuPrincipal.Visible = false;
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            openChildForm(new vendas.FrmCaixa(), sender);
            menuPrincipal.Visible = false;
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null; // Definir activeForm como null para indicar que nenhum formulário está aberto
                lblTitle.Text = "HOME"; // Restaurar o título para "HOME" quando nenhum formulário está aberto
                btnCloseChildForm.Visible = false; // Esconde o botão de fechar quando nenhum formulário está aberto
                menuPrincipal.Visible = true;
            }
        }
        private void Reset()
        {
            //DisableButton();
            lblTitle.Text = "HOME";
            currentButton = null;
            btnCloseChildForm.Visible = true;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            statusData.Text = DateTime.Today.ToString("dd/MM/yyyy");
            statusHora.Text = DateTime.Now.ToString("HH:mm:ss");

            lblUsuario.Text = Verificar.NomeUsuario;
            lblCargo.Text = Verificar.CargoUsuario;

            this.WindowState = FormWindowState.Maximized;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            statusData.Text = DateTime.Today.ToString("dd/MM/yyyy");

            statusHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
