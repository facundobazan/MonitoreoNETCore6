using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.MetaData
{
    public interface IProvince
    {
        [Required(ErrorMessage = @"El campo {0} es obligatorio")]
        [Display(Name = @"País Id")]
        public int CountryId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Provincia")]
        [StringLength(30, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string ProvinceName { get; set; }
    }
}
