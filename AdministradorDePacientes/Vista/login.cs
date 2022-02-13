using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Vista
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textUser_Enter(object sender, EventArgs e)
        {
            if(textUser.Text == "UserName")
            {
                textUser.Text = "";
                textUser.ForeColor = Color.LightGray;
            }
        }

        private void textUser_Leave(object sender, EventArgs e)
        {
            if(textUser.Text == "")
            {
                textUser.Text = "UserName";
                textUser.ForeColor = Color.DimGray;
            }
        }

        private void textClave_Enter(object sender, EventArgs e)
        {
            if(textClave.Text == "Password")
            {
                textClave.Text = "";
                textClave.ForeColor = Color.LightGray;
                textClave.UseSystemPasswordChar = true;
            }
        }

        private void textClave_Leave(object sender, EventArgs e)
        {
            if(textClave.Text == "")
            {
                textClave.Text = "Password";
                textClave.ForeColor = Color.DimGray;
                textClave.UseSystemPasswordChar = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textUser.Text != "UserName")
            {
                if (textClave.Text != "Password")
                {
                    if (textUser.Text == "Admin" & textClave.Text == "123456") //HARCODEO --> aún no "sabemos" BD
                    {
                        Principal principal = new Principal();
                        principal.Show();
                        this.Hide();
                    }
                    else 
                    {
                        msgError("Incorrect username or password entered. \n  Please try again.");
                        textClave.Clear();
                        textClave.Text = "Password";
                        textClave.ForeColor = Color.DimGray;
                        textClave.UseSystemPasswordChar = false;
                        textUser.Focus();
                    }
                        

                }
                else
                    msgError("Please enter Password.");
            }
            else
                msgError("Please enter UserName.");

        }

        private void msgError(string msg)
        {
            lblErrorMessageError.Text = "   " + msg;
            lblErrorMessageError.Visible = true;
        }
    }
}
