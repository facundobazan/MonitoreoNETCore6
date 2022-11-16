using Domain.MetaData;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monitoreo.Server.Models
{
    [Table("Evaluacion")]
    [MetadataType(typeof(IEvaluation))]
    [Index(nameof(Date), IsUnique = false)]
    public class Evaluation : BaseEntity
    {
        public DateOnly Date { get; set; }
        public int EvaluatorEmployeeId { get; set; }
        public int EmployeeEvaluatedId { get; set; }
        public int TradeRepresentativeId { get; set; }
        public int AccountNumber { get; set; }
        public int PartitionNumber { get; set; }
        public string SignalCode { get; set; }
        public Evaluation_Options SendMobile { get; set; }
        public Evaluation_Options GenerateServiceOrder { get; set; }
        public Evaluation_Options ActiveListening { get; set; }
        public Evaluation_Options UpdateUserData { get; set; }
        public string Observations { get; set; }


        public virtual TradeRepresentative TradeRepresentative { get; set; }
        public Employee EvaluatorEmployee { get; set; }
        public Employee EmployeeEvaluated { get; set; }
    }
}
