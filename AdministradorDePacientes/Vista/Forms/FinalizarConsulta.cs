using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Forms
{
    public partial class FinalizarConsulta : Form
    {
        private Clinica clinica;

        public FinalizarConsulta(Clinica clinica)
        {
            InitializeComponent();
            this.clinica = clinica;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (comboBoxMedicos.SelectedIndex >= 0 & comboBoxPaciente.SelectedIndex >= 0)
            {
                int index = comboBoxMedicos.SelectedIndex;
                clinica.Consultas[index].Medico.Atendiendo = false; //ANTES DE QUITARLO DE LA LISTA DE CONSULTAS DEBO CAMBIAR SU ESTADO DEL MÉDICO A LIBRE
                clinica.Consultas[index].Medico.CantPacientesAtendidos++; // Aumento que atendió a un paciente más
                clinica.Consultas.Remove(clinica.Consultas[index]);

                ClearItems();
                MessageBox.Show("Se Finalizó correctamente la consulta", "Clinica", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ActualizarMedicos(); // lo actualizo por si el usuario se queda en el mismo panel, ya que debería de ver los médicos que aún siguen en consulta
            }
            else
                MessageBox.Show("Seleccione el Médico y su Paciente", "Clinica", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void FinalizarConsulta_Load(object sender, EventArgs e)
        {
            if (clinica.Consultas.Count != 0)
            {
                ActualizarMedicos();
            }
            else { // ME SIRVE PARA CUANDO SE SELECCIONE DEL MENÚ --> FINALIZAR Y NO HAYA NINGÚNA CONSULTA, NO MUESTRE EL CARTEL(meesageBox) ANTES DE QUE SE HAYA CARGADO EL PANEL DE FINALIZACIÓN
                Thread t = new Thread(ShowMessageEmpty);
                t.Start();   
            }
        }

        private void ShowMessageEmpty()
        {
            Thread.Sleep(300);
            MessageBox.Show("No hay Consultar para Finalizar", "Clinica", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void comboBoxMedicos_Validating(object sender, CancelEventArgs e)
        {
            if (!(comboBoxMedicos.SelectedIndex >= 0))
                errorProvider1.SetError(comboBoxMedicos, "Seleccione un Médico");
            else
                errorProvider1.Clear();
        }

        private void comboBoxPacientes_Validating(object sender, CancelEventArgs e)
        {
            if ( !(comboBoxMedicos.SelectedIndex >= 0) & !(comboBoxPaciente.SelectedIndex >= 0))
                errorProvider2.SetError(comboBoxPaciente, "Seleccione un Paciente");
            else
                errorProvider2.Clear();
        }

        private void ActualizarPaciente(Consulta consulta)
        {
            if (clinica.Consultas.Count == 0)
                MessageBox.Show("No hay Consultas para Finalizar", "Clinica", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //Agrego el siguiente paciente a la cola
            else
            {
                comboBoxPaciente.Items.Clear();
                comboBoxPaciente.Items.Add($"{consulta.Paciente.Nombre} - {consulta.Paciente.Dni}");
            }
                
        }

        private void ActualizarMedicos()
        {
            if (clinica.Consultas.Count == 0)
            {
                Thread.Sleep(1000);
                MessageBox.Show("No hay Consultas para Finalizar", "Clinica", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Agrego los médicos disponibles al comboBox
                foreach (Consulta consulta in clinica.Consultas)
                {
                    comboBoxMedicos.Items.Add($"{consulta.Medico.Nombre} {consulta.Medico.Apellido} - {consulta.Medico.Especialidad}");
                }
            }
        }

        private void ClearItems()
        {
            comboBoxMedicos.Text = "Seleccionar";
            comboBoxPaciente.Text = "Seleccionar";
            comboBoxMedicos.Items.Clear();
            comboBoxPaciente.Items.Clear();

        }

        private void comboBoxMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxMedicos.SelectedIndex;
            ActualizarPaciente(clinica.Consultas[index]);

        }


    }
}
