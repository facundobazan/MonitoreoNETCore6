using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Domain.MetaData
{
    public interface IAddressType
    {
        [Required(ErrorMessage = @"El campo {0} es obligatorio")]
        [Display(Name = @"Tipo de dirección")]
        [StringLength(16, ErrorMessage = @"El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 4)]
        public string AddressTypeName { get; set; }

        [Required(ErrorMessage = @"El campo {0} es obligatorio")]
        [Display(Name = @"Descripción")]
        [StringLength(20, ErrorMessage = @"El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 4)]
        public string Description { get; set; }
    }
}
