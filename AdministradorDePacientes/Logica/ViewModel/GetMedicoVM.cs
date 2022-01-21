using System;
using System.Collections.Generic;
using System.Text;

namespace Logica.ViewModel
{
    public class GetMedicoVM
    {
        private string nombre;
        private string apellido;
        private string especialidad;

        public GetMedicoVM(string nombre, string apellido, string especialidad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.especialidad = especialidad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
    }
}
