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
    public partial class IngresarMedico : Form
    {
        private Clinica clinica;
        public IngresarMedico(Clinica clinica)
        {
            InitializeComponent();
            this.clinica = clinica;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearProviders();
            ClearText();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (textName.Text.StringValidation() & textLastName.Text.StringValidation() & textAge.Text.AgeValidation() & textDni.Text.DniValidation() & comboBoxEspecialidad.SelectedIndex >= 0)
            {

                clinica.AgregarMedico(textName.Text, textLastName.Text, textDni.Text, Int32.Parse(textAge.Text), comboBoxEspecialidad.Text);

                this.ClearText();

                MessageBox.Show("Se Ingresó el Médico Correctamente");

            }
            else
            {
                MessageBox.Show("Ingrese todos los datos correctos por favor");

            }

        }





        private void textName_Validating(object sender, CancelEventArgs e)
        {
            if (!textName.Text.StringValidation())
                errorProvider1.SetError(textName, "Ingrese un Nombre correcto");
            else
                errorProvider1.Clear();
        }

        private void textLastName_Validating(object sender, CancelEventArgs e)
        {
            if(!textLastName.Text.StringValidation())
                errorProvider2.SetError(textLastName, "Ingrese un Apellido correcto");
            else
                errorProvider2.Clear();
        }

        private void textDni_Validating(object sender, CancelEventArgs e)
        {
            if (!textDni.Text.DniValidation())
                errorProvider4.SetError(textDni, "Ingrese un DNI correcto");
            else
                errorProvider4.Clear();
        }

        private void textAge_Validating(object sender, CancelEventArgs e)
        {
            if (!textAge.Text.AgeValidation())
                errorProvider3.SetError(textAge, "Ingrese una Edad correcta entre 1 y 111 años");
            else
                errorProvider3.Clear();

        }

        private void comboBoxEspecialidad_Validating(object sender, CancelEventArgs e)
        {
            if (!(comboBoxEspecialidad.SelectedIndex >= 0))
                errorProvider5.SetError(comboBoxEspecialidad, "Seleccione una Opción");
            else
                errorProvider5.Clear();

        }

        private void ClearText()
        {
            textName.Text = "";
            textLastName.Text = "";
            textAge.Text = "";
            textDni.Text = "";
            comboBoxEspecialidad.Text = "Seleccionar";
        }

        private void ClearProviders()
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
            errorProvider5.Clear();
        }

        
    }
}
