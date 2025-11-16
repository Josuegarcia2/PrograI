using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using webappclinicaodontologica.Models;

namespace webappclinicaodontologica.Models
{
    [Table("Roles")]
    public class Rol
    {
        [Key]

        public int IdRol { get; set; }
        public string RolNombre { get; set; }

        public ICollection<Empleado> Empleados { get; set; }


    }
}



