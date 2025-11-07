using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using webappclinicaodontologica.Models;

namespace webappclinicaodontologica.Models
{
    [Table("Roles")]
    public class Rol
    {
        public int IdRol { get; set; }
        public string NombreRol { get; set; }

        public ICollection<Empleado> Empleados { get; set; }
    }
}



