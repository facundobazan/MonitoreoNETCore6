using System.ComponentModel.DataAnnotations;

namespace Domain.MetaData
{
    public interface IPerson
    {
        [Required(ErrorMessage = @"El campo {0} es obligatorio")]
        [Display(Name = "Nombre")]
        [StringLength(40, ErrorMessage = @"El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 6)]
        public string FistName { get; set; }

        [Required(ErrorMessage = @"El campo {0} es obligatorio")]
        [Display(Name = "Apellido")]
        [StringLength(40, ErrorMessage = @"El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 6)]
        public string LastName { get; set; }
    }
}
