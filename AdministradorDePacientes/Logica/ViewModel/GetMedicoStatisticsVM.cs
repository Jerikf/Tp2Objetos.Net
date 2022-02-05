using System;
using System.Collections.Generic;
using System.Text;

namespace Logica.ViewModel
{
    public class GetMedicoStatisticsVM
    {
        private string nombre;
        private string especialidad;
        private int cantDePacientesAtendidos;

        public GetMedicoStatisticsVM(string nombre, string especialidad, int cantDePacientesAtendidos)
        {
            this.nombre = nombre;
            this.especialidad = especialidad;
            this.cantDePacientesAtendidos = cantDePacientesAtendidos;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public int CantDePacientesAtendidos { get => cantDePacientesAtendidos; set => cantDePacientesAtendidos = value; }
    }
}
