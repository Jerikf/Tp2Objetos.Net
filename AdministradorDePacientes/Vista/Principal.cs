using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Principal : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
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

                //actual hijo del form
                // TODO --> Modificar el panel menu por IconChar en vez de btns, así me ahorraría todos los if.
                /*
                if(currentBtn.Text == "Ingresar Paciente")
                {
                    iconCurrentChildForm.IconChar = IconChar.UserInjured;
                }else if(currentBtn.Text == "Ingresar Médico")
                {
                    iconCurrentChildForm.IconChar = IconChar.UserMd;

                }else if(currentBtn.Text == "Asignar Médico")
                {
                    iconCurrentChildForm.IconChar = IconChar.NotesMedical;

                }else if(currentBtn.Text == "Estado del Médico")
                {
                    iconCurrentChildForm.IconChar = IconChar.UserNurse;

                }else if (currentBtn.Text == "Listado de Pacientes")
                {
                    iconCurrentChildForm.IconChar = IconChar.ClipboardList;

                }else if (currentBtn.Text == "Listado de Medicos")
                {
                    iconCurrentChildForm.IconChar = IconChar.ClipboardList;

                }
                else if (currentBtn.Text == "Finalizar Consulta")
                {
                    iconCurrentChildForm.IconChar = IconChar.SignOutAlt;

                }else if (currentBtn.Text == "Estadisticas")
                {
                    iconCurrentChildForm.IconChar = IconChar.ChartBar;

                }*/

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

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);

        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void btnAsignarMedico_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
        }

        private void btnListadoPacientes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
        }

        private void btnFinalizarConsulta_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
        }

        private void btnEstadistica_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
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
        }

        private void iconMedico_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void iconAsignarMedico_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
        }

        private void iconEstadoMedico_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
        }

        private void iconListPacientes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
        }

        private void iconListMedicos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
        }

        private void iconEstadisticas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
        }

        private void iconFinalizarConsulta_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
        }
    }
}
