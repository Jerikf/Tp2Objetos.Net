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
    public partial class AsignarMedico : Form
    {
        private Clinica clinica;
        public AsignarMedico(Clinica clinica)
        {
            InitializeComponent();
            this.clinica = clinica;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if(comboBoxMedicos.SelectedIndex >= 0 & comboBoxPaciente.SelectedIndex >= 0)
            {
                
                //---> Como la lista de médicos se muestra en orden como se guardaron, entonces cada índice del comobox seleccionado indicará la posición en la lista de médicos
                Medico medico = clinica.Medicos[comboBoxMedicos.SelectedIndex];

                // VERIFICAR QUE EL MÉDICO NO ESTÉ ATENDIENDO --> ESTO NO HARÍA FALTA SI HABRÍA UNA LISTA DE ESPERA
                if (medico.Atendiendo)
                    MessageBox.Show("Ups!, el médico se encuentra atendiendo a otro paciente", "Clínica", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    Paciente paciente = clinica.Pacientes.Dequeue(); // saco al paciente que será atendido
                    medico.Atendiendo = true;
                    Consulta consulta = new Consulta(paciente, medico);
                    clinica.Consultas.Add(consulta);
                    MessageBox.Show($"El médico {medico.Nombre} atenderá al paciente {paciente.Nombre} {paciente.Apellido}");
                }


                //Limpiar Campos
                comboBoxMedicos.Text = "Seleccionar";
                comboBoxPaciente.Text = "Seleccionar";

                comboBoxPaciente.Items.Clear();// Limpio el paciente que mostraba
                ActualizarPaciente(); //Actualizo con el nuevo paciente que podrá ser atendido
            }
            else
            {
                MessageBox.Show("Seleccione todos los campos", "Clinica", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void comboBoxMedicos_Validating(object sender, CancelEventArgs e)
        {
            if(!(comboBoxMedicos.SelectedIndex >= 0))
                errorProvider1.SetError(comboBoxMedicos, "Seleccione un Médico");
            else
                errorProvider1.Clear();

        }

        private void comboBoxPaciente_Validating(object sender, CancelEventArgs e)
        {
            if (!(comboBoxPaciente.SelectedIndex >= 0))
                errorProvider2.SetError(comboBoxPaciente, "Seleccione un Paciente");
            else
                errorProvider2.Clear();

        }

        private void AsignarMedico_Load(object sender, EventArgs e)
        {
            ActualizarMedicos();
            ActualizarPaciente();

        }

        private void ActualizarPaciente()
        {
            if (clinica.Pacientes.Count == 0)
                MessageBox.Show("No hay pacientes para asignar", "Clinica", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //Agrego el siguiente paciente a la cola
            else
                comboBoxPaciente.Items.Add($"{clinica.Pacientes.Peek().Nombre} - {clinica.Pacientes.Peek().Dni}");
        }

        private void ActualizarMedicos()
        {
            //Agrego los médicos disponibles al comboBox
            foreach (Medico medico in clinica.Medicos)
            {
                //if (!medico.Atendiendo)
                comboBoxMedicos.Items.Add($"{medico.Nombre} {medico.Apellido} - {medico.Especialidad}");
            }
        }
    }
}
