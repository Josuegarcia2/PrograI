using System.ComponentModel.DataAnnotations;

namespace webappclinicaodontologica.Models
{
    public class LoginViewModel
    {
        internal int rol_id;

        [Key]
        [Required]
        public string usuario_nombre { get; set; }

        [Required]
        public string contrasena { get; set; }

        [Required]
        public string nombre_rol { get; set; }
    }
}
