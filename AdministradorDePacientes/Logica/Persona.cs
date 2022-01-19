using System;

namespace Logica
{
    /// <summary>
    /// Clase Padre el cual tendrá como hijos a Paciente y Médico
    /// </summary>
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private string dni;
        private int edad;

        public Persona(string nombre, string apellido, string dni, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dni { get => dni; set => dni = value; }
        public int Edad { get => edad; set => edad = value; }

        /// <summary>
        /// Método abstracto para que los hijos implementen dicho método
        /// </summary>
        public abstract void miInfo();

        /// <summary>
        /// Método que se puede puede sobreescribir en las clases hijas
        /// </summary>
        /// <returns>  Devuelve la cadena diciendo su nombre </returns>
        public virtual string Saludar()
        {
            return $"Hola mi nombre es  {this.nombre} y soy un ";

        }
    }
}
