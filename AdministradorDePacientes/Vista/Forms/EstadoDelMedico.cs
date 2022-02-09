using Common.validations;
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
    public partial class EstadoDelMedico : Form
    {
        private Clinica clinica;
        public EstadoDelMedico(Clinica clinica)
        {
            InitializeComponent();
            this.clinica = clinica;
        }

        private void EstadoDelMedico_Load(object sender, EventArgs e)
        {
            foreach (var medico in clinica.ObtenerMedicosStateVM())
            {
                int index = dgvAtendiendo.Rows.Add();
                dgvAtendiendo.Rows[index].Cells[0].Value = medico.Nombre;
                dgvAtendiendo.Rows[index].Cells[1].Value = medico.Especialidad;
                dgvAtendiendo.Rows[index].Cells[2].Value = medico.Atendiendo;

            }
        }
    }
}
