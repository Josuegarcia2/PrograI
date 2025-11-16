
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webappclinicaodontologica.Models
    {
        public class Paciente
        {
            [Key]
            public int IdPaciente { get; set; }

            public string Nombre { get; set; }
            public string Apellido { get; set; }

            public int Edad { get; set; }

            public string Correo { get; set; }
            public string Telefono { get; set; }

            public bool Estado { get; set; }
        }
}



