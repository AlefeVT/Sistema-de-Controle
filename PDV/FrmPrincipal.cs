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
            this.Text = string.Empty;
            this.ControlBox = false;

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btnCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(45, 67, 96);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void openChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            //openChildForm(new cadastros.FrmProdutos(), sender);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            openChildForm(new cadastros.FrmFuncionarios(), sender);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            openChildForm(new cadastros.FrmClientes(), sender);
        }

        private void btnMovimentacoes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();

            Reset();
        }
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Deseja realmente Fechar O Sistema ?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            openChildForm(new cadastros.FrmCargo(), sender);
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            statusData.Text = DateTime.Today.ToString("dd/MM/yyyy");
            statusHora.Text = DateTime.Now.ToString("HH:mm:ss");

            lblUsuario.Text = Verificar.NomeUsuario;
            lblCargo.Text = Verificar.CargoUsuario;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            statusData.Text = DateTime.Today.ToString("dd/MM/yyyy");

            statusHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
