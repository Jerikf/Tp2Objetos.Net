using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class Medico : Persona
    {
        private string especialidad;
        private bool atendiendo;
        private int cantPacientesAtendidos;

        public Medico(string nombre, string apellido, string dni, int edad, string especialidad, bool atendiendo, int cantPacientesAtendidos) : base(nombre, apellido, dni, edad)
        {
            this.especialidad = especialidad;
            this.atendiendo = atendiendo;
            this.cantPacientesAtendidos = cantPacientesAtendidos;
        }

        public string Especialidad { get => especialidad; set => especialidad = value; }
        public bool Atendiendo { get => atendiendo; set => atendiendo = value; }
        public int CantPacientesAtendidos { get => cantPacientesAtendidos; set => cantPacientesAtendidos = value; }

        /// <summary>
        /// Dos médicos son iguales ti tienen el mismo dni y especialidad
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>True si ambos médicos son iguales, false caso contrario</returns>
        public override bool Equals(object obj)
        {
            return obj is Medico medico &&
                   Dni == medico.Dni &&
                   especialidad == medico.especialidad;
        }

        public override void miInfo()
        {
            Console.WriteLine( base.toString() + $"Especialidad : {this.especialidad} \n Atendiendo : {((atendiendo)? "SI" : "no")} \n Cantidad de Pacientes Atendidos : {this.cantPacientesAtendidos}");
        }

        public override string Saludar()
        {
            return $"{base.Saludar()} Médico";
        }
    }
}
