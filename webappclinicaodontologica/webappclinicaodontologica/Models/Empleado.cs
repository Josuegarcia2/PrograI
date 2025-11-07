using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webappclinicaodontologica.Models
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string Estado { get; set; }

        public int IdRol { get; set; }
        public Rol Rol { get; set; }


        
    }
}
