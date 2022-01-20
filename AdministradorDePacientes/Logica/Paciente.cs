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
        private int numeroDeLlegada;
        private ObraSocial tipo;

        public Paciente(string nombre, string apellido, string dni, int edad, int numeroDeLlegada, ObraSocial tipo) : base(nombre, apellido, dni, edad)
        {
            this.numeroDeLlegada = numeroDeLlegada;
            this.tipo = tipo;
        }

        public override bool Equals(object obj)
        {
            return obj is Paciente paciente &&
                   Nombre == paciente.Nombre &&
                   Dni == paciente.Dni;
        }

        public override void miInfo()
        {
            Console.WriteLine(base.toString() + $"Número de llegada : {this.numeroDeLlegada} \n Obra social : {tipo}");
        }

        public override string Saludar()
        {
            return $"{base.Saludar()} Paciente";
        }
    }   
}
