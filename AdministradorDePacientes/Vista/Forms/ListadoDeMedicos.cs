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
    public partial class ListadoDeMedicos : Form
    {
        private Clinica clinica;
        public ListadoDeMedicos(Clinica clinica)
        {
            InitializeComponent();
            this.clinica = clinica;
        }

        private void ListadoDeMedicos_Load(object sender, EventArgs e)
        {
            dgvListadoDeMedicos.DataSource = clinica.ObtenerMedicosVM();
        }

        
    }
}
