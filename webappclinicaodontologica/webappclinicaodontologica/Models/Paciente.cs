using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webappclinicaodontologica.Models
{
    public class Paciente
    {
        public int IdPaciente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string Genero { get; set; }
    }
}
