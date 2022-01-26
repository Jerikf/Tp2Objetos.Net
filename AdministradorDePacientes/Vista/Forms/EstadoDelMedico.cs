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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if(textName.Text.StringValidation() & textDni.Text.DniValidation())
            {
 
                List<Medico> medicos = clinica.Medicos;
                int pos = 0;
                bool seEncontro = false;
                while(pos < medicos.Count & !seEncontro)
                {
                    if(medicos[pos].Dni == textDni.Text & medicos[pos].Nombre == textName.Text)
                        seEncontro = true;
                    pos++;
                }

                if(seEncontro)
                    MessageBox.Show($"Médico {(medicos[--pos].Atendiendo ? "OCUPADO" : "DISPONIBLE")}", "Clinica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("El MÉDICO NO EXISTE EN NUESTRA  CLÍNICA", "Clinica" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                textName.Text = "";
                textDni.Text = "";

            }
            else
            {
                MessageBox.Show("Ingrese todos los datos correctos por favor", "Clinica", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void textName_Validating(object sender, CancelEventArgs e)
        {
            if (!textName.Text.StringValidation())
                errorProvider1.SetError(textName, "Ingrese un Nombre correcto");
            else
                errorProvider1.Clear();

        }

        private void textDni_Validating(object sender, CancelEventArgs e)
        {
            if (!textDni.Text.DniValidation())
                errorProvider2.SetError(textDni, "Ingrese un DNI correcto");
            else
                errorProvider2.Clear();

        }
    }
}
