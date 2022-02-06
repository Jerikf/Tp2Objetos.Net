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
    public partial class Estadisticas : Form
    {
        private Clinica clinica;
        public Estadisticas(Clinica clinica)
        {
            InitializeComponent();
            this.clinica = clinica;
        }

       

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            var listMedicosVM = clinica.ObtenerMedicosStatisticsVM().OrderByDescending(medico => medico.CantDePacientesAtendidos).ToList();
            int maxEspecialidad = 0;
            string especialidadMaxima = MedicoMayor.Text = listMedicosVM.First().Especialidad;
            foreach (var medico in listMedicosVM)
            {
                int index = dgvPrueba2.Rows.Add();
                dgvPrueba2.Rows[index].Cells[0].Value = medico.Nombre;
                dgvPrueba2.Rows[index].Cells[1].Value = medico.Especialidad;
                dgvPrueba2.Rows[index].Cells[2].Value = medico.CantDePacientesAtendidos;

                if(especialidadMaxima == medico.Especialidad)
                {
                    maxEspecialidad += medico.CantDePacientesAtendidos;
                }
                else
                {
                    if(medico.CantDePacientesAtendidos > maxEspecialidad)
                    {
                        maxEspecialidad = medico.CantDePacientesAtendidos;
                        especialidadMaxima = medico.Especialidad;
                    }
                }

            }

            MedicoMayor.Text = (listMedicosVM.First().CantDePacientesAtendidos == 0 ? "NINGUNO" : listMedicosVM.First().Nombre);
            MedicoMenor.Text = (listMedicosVM.Last().CantDePacientesAtendidos == 0 ? "NINGUNO" : listMedicosVM.Last().Nombre);
            EspecialidadMax.Text = (maxEspecialidad == 0 ? "NINGUNO" : especialidadMaxima);


        }
    }
}
