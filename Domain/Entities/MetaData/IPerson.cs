using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.MetaData
{
    public interface IPerson
    {
        [Required(ErrorMessage = @"El campo {0} es obligatorio")]
        [Display(Name = "Nombre")]
        [StringLength(40, ErrorMessage = @"El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 6)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = @"El campo {0} es obligatorio")]
        [Display(Name = "Apellido")]
        [StringLength(40, ErrorMessage = @"El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 6)]
        public string LastName { get; set; }

        [Required(ErrorMessage = @"El campo {0} es obligatorio")]
        [Display(Name = @"Dirección Id")]
        public int AddressId { get; set; }
    }
}
