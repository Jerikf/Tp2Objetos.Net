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
    public partial class IngresarPaciente : Form
    {
        private Clinica clinica;
        public IngresarPaciente(Clinica clinica)
        {
            InitializeComponent();
            this.clinica = clinica;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (textName.Text.StringValidation() & textLastName.Text.StringValidation() & textAge.Text.AgeValidation() & textDni.Text.DniValidation() & comboBoxObraSocial.SelectedIndex >= 0)
            {
                ObraSocial obraSocial = ObraSocial.NoTiene;
                if (comboBoxObraSocial.Text == "Cobertura Básica")
                {
                    obraSocial = ObraSocial.CoberturaBasica;

                }
                else if (comboBoxObraSocial.Text == "Cobertura Completa")
                {
                    obraSocial = ObraSocial.CoberturaCompleta;

                }

                clinica.AgregarPaciente(textName.Text, textLastName.Text, textDni.Text, Int32.Parse(textAge.Text), obraSocial);

                this.ClearText();

                MessageBox.Show("Se Ingresó el Paciente Correctamente");
                
            }
            else
            {
                MessageBox.Show("Ingrese todos los datos correctos por favor");

            }
        }

        private void ClearText()
        {
            textName.Text = "";
            textLastName.Text = "";
            textAge.Text = "";
            textDni.Text = "";
            comboBoxObraSocial.Text = "";

        }

        private void ClearProviders()
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
            errorProvider5.Clear();
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
            if (!textLastName.Text.StringValidation())
                errorProvider2.SetError(textLastName, "Ingrese un Apellido correcto");
            else
                errorProvider2.Clear();
        }
        private void textAge_Validating(object sender, CancelEventArgs e)
        {
            if (!textAge.Text.AgeValidation())
                errorProvider3.SetError(textAge, "Ingrese una Edad correcta entre 1 y 111 años");
            else
                errorProvider3.Clear(); 
        }

        private void textDni_Validating(object sender, CancelEventArgs e)
        {
            if (!textDni.Text.DniValidation())
                errorProvider4.SetError(textDni, "Ingrese un DNI correcto");
            else
                errorProvider4.Clear();
        }

        private void comboBoxObraSocial_Validating(object sender, CancelEventArgs e)
        {
            if (!(comboBoxObraSocial.SelectedIndex >= 0))
                errorProvider5.SetError(comboBoxObraSocial, "Seleccione una Opción");
            else
                errorProvider5.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearProviders();
            ClearText();
        }
    }
}
