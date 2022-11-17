using System.ComponentModel.DataAnnotations;

namespace Domain.MetaData
{
    public interface ICity
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Provincia Id")]
        public int ProvinceId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Ciudad")]
        [StringLength(30, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string CityName { get; set; }
    }
}
