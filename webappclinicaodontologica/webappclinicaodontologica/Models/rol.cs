using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webappclinicaodontologica.Models
{
    [Table("rol")]
    public class Rol
    {
        [Key]
        [Column("id_rol")]
        public int id_rol { get; set; }

        [Required]
        [Column("nombre_rol")]
        [StringLength(50)]
        public string nombre_rol { get; set; }
    }
}


