using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webappclinicaodontologica.Models
{
    public class Usuario
    {
        [Key]
        [Column("Id_Usuario")]
        public int Id_Usuario { get; set; }

        [Required]
        [Column("usuario_nombre")]
        [StringLength(100)]
        public string usuario_nombre { get; set; }

        [Required]
        [Column("contrasena")]
        [StringLength(100)]
        public string contrasena { get; set; }

        [Required]
        [Column("rol_id")]
        public int rol_id { get; set; }
    }
}
