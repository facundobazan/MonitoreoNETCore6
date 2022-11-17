using System.ComponentModel.DataAnnotations;

namespace Domain.MetaData
{
    public interface ICountry
    {
        [Required(ErrorMessage = @"El campo {0} es obligatorio")]
        [Display(Name = @"País")]
        [StringLength(30, ErrorMessage = @"El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        string CountryName { get; set; }
    }
}
