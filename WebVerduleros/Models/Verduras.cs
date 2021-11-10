using System.ComponentModel.DataAnnotations;

namespace WebVerduleros.Models
{
    public class Verduras
    {
        [Key]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} es requerido")]
        [StringLength(1, MinimumLength = 1, ErrorMessage = "La longitud de {0} debe estar entre {2} y {1}")]
        public int VerduraId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El nombre es requerido")]
        [Display(Name = "Nombre del item")]
        public string Verdura { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} es requerido")]
        [StringLength(3, MinimumLength = 1, ErrorMessage = "La longitud de {0} debe estar entre {1} y {3}")]
        public int Cantidad { get; set; }

    }
}
