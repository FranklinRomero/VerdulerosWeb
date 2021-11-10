using System.ComponentModel.DataAnnotations;

namespace WebVerduleros.Models
{
    public class Verduras
    {
        [Key]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} es requerido")]
        public int VerduraId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El nombre es requerido")]
        [Display(Name = "Nombre del item")]
        public string Verdura { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} es requerido")]
        public int Cantidad { get; set; }

    }
}
