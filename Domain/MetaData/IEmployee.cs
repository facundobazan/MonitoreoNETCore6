using System.ComponentModel.DataAnnotations;

namespace Domain.MetaData
{
    public interface IEmployee
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int PersonId { get; set; }

        [Display(Name = "Usuario de Bykom")]
        [StringLength(16, ErrorMessage = @"El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 4)]
        public string BykomUserName { get; set; }

        [Display(Name = "Interno")]
        [MinLength(4, ErrorMessage = "El campo {0} no puede tener mas de {1} digitos")]
        public int Intern { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int WorkAreaId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int PositionId { get; set; }

        /*
        [ForeignKey("PersonId")]
        public virtual Person Person { get; set; }

        [ForeignKey("WorkAreaId")]
        public virtual WorkArea WorkArea { get; set; }

        [ForeignKey("PositionId")]
        public virtual Position Position { get; set; }

        public virtual IEnumerable<Evaluation> Evaluations { get; set; }*/
    }
}
