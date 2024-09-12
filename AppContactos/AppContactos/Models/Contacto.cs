using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppContactos.Models
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre es obligatorio")]
        [StringLength(maximumLength: 25, MinimumLength = 2, ErrorMessage = "El Nombre debe tener de {2} a {1} caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Apellido es obligatorio")]
        [StringLength(maximumLength: 25, MinimumLength = 2, ErrorMessage = "El Apellido debe tener de {2} a {1} caracteres")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El Telefono es obligatorio")]
        [StringLength(maximumLength: 10, ErrorMessage = "El Telefono debe de tener maximo {1} digitos")]
        public string Telefono { get; set; }

        [StringLength(maximumLength: 50, ErrorMessage = "El Email debe de tener maximo {1} caracteres")]
        [EmailAddress]
        public string Email { get; set; }

        public string Notas { get; set; }

        [DisplayName("Fecha de Creacion")]
        public DateTime FechaCreacion { get; set; }
    }
}
