using System.ComponentModel.DataAnnotations;

namespace Monitoreo.Server.Models
{
    public class TradeRepresentative : BaseEntity
    {
        [Required]
        [Display(Name = "Representante comercial")]
        [MaxLength(2)]
        public string TradeRepresentativeName { get; set; } = string.Empty;

        public virtual IEnumerable<Evaluation> Evaluations { get; set; }
    }
}
