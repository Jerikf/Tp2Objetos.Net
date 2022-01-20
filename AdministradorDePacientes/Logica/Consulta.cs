using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class Consulta
    {
        Paciente paciente;
        Medico medico;
        string resultado;

        public Consulta(Paciente paciente, Medico medico)
        {
            this.paciente = paciente;
            this.medico = medico;
        }

        public Paciente Paciente { get => paciente; set => paciente = value; }
        public Medico Medico { get => medico; set => medico = value; }
        public string Resultado { get => resultado; set => resultado = value; }

        public override bool Equals(object obj)
        {
            return obj is Consulta consulta &&
                   EqualityComparer<Paciente>.Default.Equals(Paciente, consulta.Paciente) &&
                   EqualityComparer<Medico>.Default.Equals(Medico, consulta.Medico);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Paciente, Medico);
        }
    }
}
