using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Forms
{
    public partial class IngresarPaciente : Form
    {
        private Clinica clinica;
        public IngresarPaciente(Clinica clinica)
        {
            InitializeComponent();
            this.clinica = clinica;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
