using Domain.Entities.MetaData;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monitoreo.Server.Models
{
    [Table(@"Evaluación")]
    [MetadataType(typeof(IEvaluation))]
    [Index(nameof(Date), IsUnique = false)]
    public class Evaluation : BaseEntity
    {
        public DateTime Date { get; set; }
        public int EvaluatorEmpleeId { get; set; }
        public int EmployeeId { get; set; }
        //public int EmployeeId { get; set; }
        //public int Employee_Id { get; set; }
        public int TradeRepresentativeId { get; set; }
        public int AccountNumber { get; set; }
        public int PartitionNumber { get; set; }
        public string SignalCode { get; set; }
        public Evaluation_Options SendMobile { get; set; }
        public Evaluation_Options GenerateServiceOrder { get; set; }
        public Evaluation_Options ActiveListening { get; set; }
        public Evaluation_Options UpdateUserData { get; set; }
        public string Observations { get; set; }

        [ForeignKey("EvaluatorEmpleeId")]
        public virtual Employee Evaluator { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }


        public virtual TradeRepresentative TradeRepresentative { get; set; }
        //public virtual Employee EmployeeEvaluated { get; set; }

        /*
         * https://learn.microsoft.com/es-mx/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key
         * 
         * Limitaciones
         * Cuando hay varias propiedades de navegación definidas entre dos tipos (es decir, más de un par de navegaciones que apuntan entre sí), 
         * las relaciones representadas por las propiedades de navegación son ambiguas. Tendrá que configurarlos manualmente para resolver la ambigüedad.
         */
    }
}
