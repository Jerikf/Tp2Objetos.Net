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
    }
}
