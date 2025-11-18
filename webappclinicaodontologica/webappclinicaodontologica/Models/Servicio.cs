using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace webappclinicaodontologica.Models
{
    public class Servicio
    {
        [Key]
        public int IdServicio { get; set; }

        [Required]
        public string NombreServicio { get; set; }

        [Required]
        public decimal Precio { get; set; }

        public string Descripcion { get; set; }

        public string Estado { get; set; } = "Activo";

        public string FotoUrl { get; set; }   // Guardará "/img/servicios/x.png"

       
        public int? Doctor1Id { get; set; }
        public int? Doctor2Id { get; set; }

        [JsonIgnore]
        public Empleado Doctor1 { get; set; }

        [JsonIgnore]
        public Empleado Doctor2 { get; set; }
    }
}
