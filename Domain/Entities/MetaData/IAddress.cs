using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Domain.Entities.MetaData
{
    public interface IAddress
    {
        [Required(ErrorMessage = @"El campo {0} es obligatorio")]
        [Display(Name = @"Tipo de dirección Id")]
        public int AddressTypeId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Municipio Id")]
        public int TownshipId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Calle")]
        [StringLength(50, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 4)]
        public string StreetName { get; set; }

        [Display(Name = @"Número")]
        public int StreetNumber { get; set; }
    }
}
