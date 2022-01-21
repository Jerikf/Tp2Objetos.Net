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
    public partial class ListadoDePacientes : Form
    {
        private Clinica clinica;
        public ListadoDePacientes(Clinica clinica)
        {
            InitializeComponent();
            this.clinica = clinica;

        }

        private void ListadoDePacientes_Load(object sender, EventArgs e)
        {
            this.dgvListadoPacientes.DataSource = clinica.ObtenerPacientes();
        }
    }
}
