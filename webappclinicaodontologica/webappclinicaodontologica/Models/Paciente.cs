using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webappclinicaodontologica.Models
{
    [Table("pacientes")]
    public class Paciente
    {
        [Key]
        [Column("id_paciente")]
        public int id_paciente { get; set; }

        [Required]
        [Column("nombre")]
        [StringLength(50)]
        public string nombre { get; set; }

        [Required]
        [Column("apellido")]
        [StringLength(50)]
        public string apellido { get; set; }

        [Required]
        [Column("correo")]
        [StringLength(100)]
        [EmailAddress]
        public string correo { get; set; }

        [Required]
        [Column("telefono")]
        [StringLength(15)]
        public string telefono { get; set; }

        [Required]
        [Column("direccion")]
        [StringLength(150)]
        public string direccion { get; set; }

        [Required]
        [Column("fecha_nacimiento")]
        [DataType(DataType.Date)]
        public DateTime fecha_nacimiento { get; set; }

        [Required]
        [Column("genero")]
        [StringLength(10)]
        public string genero { get; set; }
    }
}
