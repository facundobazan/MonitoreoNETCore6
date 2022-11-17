using Monitoreo.Server.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.MetaData
{
    public interface IEvaluation
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Fecha")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name ="Evaluador Id")]
        [ForeignKey("EvaluatorEmployeeId")]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Empleado Evaluado Id")]
        public int Employee_Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Representante Comercial Id")]
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

        [Required(ErrorMessage = @"El campo {0} es obligatorio")]
        [Display(Name = @"Señal")]
        [MaxLength(3, ErrorMessage = @"El campo {0} debe ser de {1} digitos")]
        [MinLength(3, ErrorMessage = @"El campo {0} debe ser de {1} digitos")]
        public string SignalCode { get; set; }

        [Required(ErrorMessage = @"El campo {0} es obligatorio")]
        [Display(Name = @"Envia móvil")]
        [MaxLength(1, ErrorMessage = @"El campo {0} debe ser de {1} digito")]
        [DefaultValue(Evaluation_Options.NA)]
        public Evaluation_Options SendMobile { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Genera servicio")]
        [MaxLength(1, ErrorMessage = @"El campo {0} debe ser de {1} digito")]
        [DefaultValue(Evaluation_Options.NA)]
        public Evaluation_Options GenerateServiceOrder { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Escucha activa")]
        [MaxLength(1, ErrorMessage = @"El campo {0} debe ser de {1} digito")]
        [DefaultValue(Evaluation_Options.NA)]
        public Evaluation_Options ActiveListening { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Actualiza datos")]
        [MaxLength(1, ErrorMessage = @"El campo {0} debe ser de {1} digito")]
        [DefaultValue(Evaluation_Options.NA)]
        public Evaluation_Options UpdateUserData { get; set; }

        [Display(Name = "Observaciones")]
        public string Observations { get; set; }
    }
}
