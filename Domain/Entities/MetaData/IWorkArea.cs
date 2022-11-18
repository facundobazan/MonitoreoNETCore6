using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.MetaData
{
    public interface IWorkArea
    {
        [Required(ErrorMessage = @"El campo {0} es obligatorio")]
        [Display(Name = @"Área de trabajo")]
        [StringLength(20, ErrorMessage = @"El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 2)]
        public string AreaName { get; set; }
    }
}
