using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public enum ObraSocial
    {
        NoTiene,
        CoberturaBasica,
        CoberturaCompleta
    };

    public class Paciente : Persona
    {
        private ObraSocial tipo;

        public Paciente(string nombre, string apellido, string dni, int edad, ObraSocial tipo) : base(nombre, apellido, dni, edad)
        {
            this.tipo = tipo;
        }

        public ObraSocial Tipo { get => tipo; set => tipo = value; }

        public override bool Equals(object obj)
        {
            return obj is Paciente paciente &&
                   Nombre == paciente.Nombre &&
                   Dni == paciente.Dni;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nombre, Dni);
        }

        public override void miInfo()
        {
            Console.WriteLine(base.toString() + $" Obra social : {tipo}");
        }

        public override string Saludar()
        {
            return $"{base.Saludar()} Paciente";
        }
    }   
}
