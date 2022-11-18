using Domain.Entities.MetaData;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monitoreo.Server.Models
{
    [Table("Representante comercial")]
    [MetadataType(typeof(ITradeRepresentative))]
    [Index(nameof(TradeRepresentativeName), IsUnique = true)]
    public class TradeRepresentative : BaseEntity
    {
        public string TradeRepresentativeName { get; set; }


        public virtual ICollection<Evaluation> Evaluations { get; set; }
    }
}
