using Monitoreo.Server.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.MetaData
{
    public interface IEvaluation
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Fecha")]
        public DateOnly Date { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [ForeignKey("EvaluatorEmployeeId")]
        public int EvaluatorEmployeeId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int EmployeeEvaluatedId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int TradeRepresentativeId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Cuenta")]
        [MaxLength(4, ErrorMessage = "El campo {0} no puede contener mas de {1} digitos")]
        public int AccountNumber { get; set; }

        [Required(ErrorMessage = @"El campo {0} es obligatorio")]
        [Display(Name = @"Partición")]
        [MaxLength(1, ErrorMessage = "El campo {0} no puede contener mas de {1} digitos")]
        [DefaultValue(0)]
        public int PartitionNumber { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Señal")]
        [MaxLength(3, ErrorMessage = "El campo {0} debe ser de {1} digitos")]
        [MinLength(3, ErrorMessage = "El campo {0} debe ser de {1} digitos")]
        public string SignalCode { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Envia movil")]
        [MaxLength(1)]
        [DefaultValue(Evaluation_Options.NA)]
        public Evaluation_Options SendMobile { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Genera servicio")]
        [MaxLength(1)]
        [DefaultValue(Evaluation_Options.NA)]
        public Evaluation_Options GenerateServiceOrder { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Escucha activa")]
        [MaxLength(1)]
        [DefaultValue(Evaluation_Options.NA)]
        public Evaluation_Options ActiveListening { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Actualiza datos")]
        [MaxLength(1)]
        [DefaultValue(Evaluation_Options.NA)]
        public Evaluation_Options UpdateUserData { get; set; }

        [Display(Name = "Observaciones")]
        public string Observations { get; set; }

        /*
        [ForeignKey("TradeRepresentativeId")]
        public virtual TradeRepresentative TradeRepresentative { get; set; }

        [ForeignKey("EvaluatorEmployeeId")]
        public Employee EvaluatorEmployee { get; set; }

        [ForeignKey("EmployeeEvaluatedId")]
        public Employee EmployeeEvaluated { get; set; }*/
    }
}
