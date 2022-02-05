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
                new Medico("Xiomara", "iwasa", "24879634", 30, "Oftamologia")
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

            this.pacientes.Enqueue(paciente1);
            this.pacientes.Enqueue(paciente2);
            this.pacientes.Enqueue(paciente3);
            this.pacientes.Enqueue(paciente4);
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


    }
}
