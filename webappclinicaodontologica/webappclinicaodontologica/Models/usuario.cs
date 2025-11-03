using System.ComponentModel.DataAnnotations;

namespace webappclinicaodontologica.Models
{
    public class usuario
    {
        [Key]
        public int id_usuario { get; set; }
        public string usuario_nombre { get; set; }
        public string contrasena { get; set; }
        public int id_rol { get; set; }
    }
}
