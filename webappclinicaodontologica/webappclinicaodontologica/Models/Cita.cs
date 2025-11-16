using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace webappclinicaodontologica.Models
{
    public class Cita
    {
        [Key]
        public int IdCita { get; set; }

        public int IdPaciente { get; set; }
        public int IdDoctor { get; set; }

        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }

        public string Motivo { get; set; }
        public string Estado { get; set; } = "Pendiente"; 

        [ForeignKey("IdPaciente")]
        public Paciente Paciente { get; set; }

        [ForeignKey("IdDoctor")]
        public Doctor Doctor { get; set; }

    }
}
