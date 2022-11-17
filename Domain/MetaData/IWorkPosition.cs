using System.ComponentModel.DataAnnotations;

namespace Domain.MetaData
{
    public interface IWorkPosition
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Puesto de trabajo")]
        [StringLength(20, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 4)]
        public string PositionName { get; set; }
    }
}
