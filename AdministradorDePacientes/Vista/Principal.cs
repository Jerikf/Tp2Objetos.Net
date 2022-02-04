using FontAwesome.Sharp;
using Logica;
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
using Vista.Forms;

namespace Vista
{
    public partial class Principal : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private Clinica clinica;
        public Principal()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 40);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            //Instancio clinica
            clinica = new Clinica();
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(105, 245, 28);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(246, 184, 49);
            public static Color color7 = Color.FromArgb(69, 234, 218);
            public static Color color8 = Color.FromArgb(232, 245, 18);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button 4; 41; 81    --> 37, 36, 81
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(10, 47, 94);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;

                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //borde de boton izquierda
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconCurrentChildForm.IconChar = ((IconButton)senderBtn).IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(4, 41, 81);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenchildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            LabelTitleChildForm.Text = childForm.Text;
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.DodgerBlue;
            LabelTitleChildForm.Text = "Home";

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPaciente_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenchildForm(new IngresarPaciente(this.clinica));
        }

        private void iconMedico_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenchildForm(new IngresarMedico(this.clinica));
        }

        private void iconAsignarMedico_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenchildForm(new AsignarMedico(this.clinica));
        }

        private void iconEstadoMedico_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenchildForm(new EstadoDelMedico(this.clinica));
        }

        private void iconListPacientes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenchildForm(new ListadoDePacientes(this.clinica));
        }

        private void iconListMedicos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenchildForm(new ListadoDeMedicos(this.clinica));
        }

        private void iconEstadisticas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
        }

        private void iconFinalizarConsulta_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            OpenchildForm(new FinalizarConsulta(this.clinica));
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
