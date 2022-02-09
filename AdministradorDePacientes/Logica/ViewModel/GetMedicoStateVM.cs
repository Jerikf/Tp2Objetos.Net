using System;
using System.Collections.Generic;
using System.Text;

namespace Logica.ViewModel
{
    public class GetMedicoStateVM
    {
        private string nombre;
        private string especialidad;
        private string atendiendo;

        public GetMedicoStateVM(string nombre, string especialidad, string atendiendo)
        {
            this.nombre = nombre;
            this.especialidad = especialidad;
            this.atendiendo = atendiendo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public string Atendiendo { get => atendiendo; set => atendiendo = value; }
    }
}
