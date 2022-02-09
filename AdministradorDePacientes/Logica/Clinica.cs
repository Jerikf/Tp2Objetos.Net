using Logica.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class Clinica
    {
        private List<Medico> medicos;
        private Queue<Paciente> pacientes;
        private List<Consulta> consultas;

        public Clinica()
        {
            this.medicos = new List<Medico>()
            {
                new Medico("Mariano", "Mendez", "14379861", 58, "Cardiologia"),
                new Medico("Juan", "Perez", "43678128", 33, "Hurologia"),
                new Medico("Nestor", "lopez", "35497616", 45, "Traumatologia"),
                new Medico("Alexander", "cruz", "34571279", 50, "Podologia"),
                new Medico("Xiomara", "iwasa", "24879634", 30, "Oftamologia"),
                new Medico("Agustin", "Pichot", "52179648", 62, "Cardiologia"),
                new Medico("Katheryn", "Maldini", "95743461", 54, "Traumatologia")
            };

            this.consultas = new List<Consulta>();

            this.pacientes = new Queue<Paciente>();
            this.AgregarPacientesHarcodeo();


        }

        public List<Medico> Medicos { get => medicos; set => medicos = value; }
        public Queue<Paciente> Pacientes { get => pacientes; set => pacientes = value; }
        public List<Consulta> Consultas { get => consultas; set => consultas = value; }

        private void AgregarPacientesHarcodeo()
        {
            Paciente paciente1 = new Paciente("Erik", "Flores", "95374512", 26, ObraSocial.CoberturaCompleta);
            Paciente paciente2 = new Paciente("Fernando", "Ustua", "95585453", 25, ObraSocial.NoTiene);
            Paciente paciente3 = new Paciente("Carlos", "Cisneros", "95347562", 28, ObraSocial.CoberturaBasica);
            Paciente paciente4 = new Paciente("Junior", "Gil", "93458736", 27, ObraSocial.CoberturaCompleta);
            Paciente paciente5 = new Paciente("Alex", "Forlan", "54826791", 32, ObraSocial.NoTiene);
            Paciente paciente6 = new Paciente("Anthony", "Palomino", "34612587", 21, ObraSocial.NoTiene);
            Paciente paciente7 = new Paciente("Leo", "Cuervo", "71829346", 32, ObraSocial.CoberturaBasica);
            Paciente paciente8 = new Paciente("Luis", "Chuz", "34152541", 29, ObraSocial.CoberturaCompleta);

            this.pacientes.Enqueue(paciente1);
            this.pacientes.Enqueue(paciente2);
            this.pacientes.Enqueue(paciente3);
            this.pacientes.Enqueue(paciente4);
            this.pacientes.Enqueue(paciente5);
            this.pacientes.Enqueue(paciente6);
            this.pacientes.Enqueue(paciente7);
            this.pacientes.Enqueue(paciente8);
        }

        public void AgregarPaciente(string nombre, string apellido, string dni, int edad, ObraSocial tipo)
        {
            Paciente paciente = new Paciente(nombre, apellido, dni, edad, tipo);
            pacientes.Enqueue(paciente);
        }

        public void AgregarMedico(string nombre, string apellido, string dni, int edad, string especialidad)
        {
            Medico medico = new Medico(nombre, apellido, dni, edad, especialidad);
            medicos.Add(medico);
        }

        public void AgregarConsulta(Consulta consulta)
        {
            consultas.Add(consulta);
        }

        public List<GetMedicoVM> ObtenerMedicosVM()
        {
            List<GetMedicoVM> medicosVM = new List<GetMedicoVM>();
            foreach(Medico medico in medicos)
            {
                GetMedicoVM medicoVM = new GetMedicoVM(medico.Nombre, medico.Apellido, medico.Especialidad);
                medicosVM.Add(medicoVM);
            }

            return medicosVM;
        }

        public List<Paciente> ObtenerPacientes()
        {
            List<Paciente> pacientesVM = new List<Paciente>();
            foreach (Paciente paciente in pacientes)
            {
                pacientesVM.Add(paciente);
            }
            return pacientesVM;
        }

        public List<GetMedicoStatisticsVM> ObtenerMedicosStatisticsVM()
        {
            List<GetMedicoStatisticsVM> medicosVM = new List<GetMedicoStatisticsVM>();
            foreach (Medico medico in medicos)
            {
                GetMedicoStatisticsVM medicoVM = new GetMedicoStatisticsVM(medico.Nombre, medico.Especialidad, medico.CantPacientesAtendidos);
                medicosVM.Add(medicoVM);
            }

            return medicosVM;

        }

        public List<GetMedicoStateVM> ObtenerMedicosStateVM()
        {
            List<GetMedicoStateVM> medicosVM = new List<GetMedicoStateVM>();
            foreach (var medico in medicos)
            {
                GetMedicoStateVM medicoVM = new GetMedicoStateVM(medico.Nombre, medico.Especialidad, medico.Atendiendo ? "SI" : "NO");
                medicosVM.Add(medicoVM);
            }
            return medicosVM;
        }


    }
}
