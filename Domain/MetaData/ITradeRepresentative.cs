using System.ComponentModel.DataAnnotations;

namespace Domain.MetaData
{
    public interface ITradeRepresentative
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Representante legal")]
        [StringLength(8, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string TradeRepresentativeName { get; set; }
    }
}
