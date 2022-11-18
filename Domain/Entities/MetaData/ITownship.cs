using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.MetaData
{
    public interface ITownship
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Ciudad Id")]
        public int CityId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Municipio")]
        [StringLength(30, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string TownshipName { get; set; }
    }
}
