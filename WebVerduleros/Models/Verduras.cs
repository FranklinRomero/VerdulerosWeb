using System.ComponentModel.DataAnnotations;

namespace WebVerduleros.Models
{
    public enum Market
    {
        abmay = 0,
        abmin = 1,
        mutu = 2,
        noviemb = 3,
        ramada = 4,
        primav = 5,
    }
    public class Verduras
    {
        [Key]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} es requerido")]
        public int VerduraId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El mercado es requerido")]
        [Display(Name = "Mercado")]
        public Market Mercado { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El nombre es requerido")]
        [Display(Name = "Verdura")]
        public string Verdura { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} es requerido")]
        public int Precio { get; set; }

        [Url]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El URL es requerido")]
        public string Imagen { get; set; }

    }
}
