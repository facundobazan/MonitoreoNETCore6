using Domain.MetaData;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monitoreo.Server.Models
{
    [Table("Empleado")]
    [MetadataType(typeof(IEmployee))]
    public class Employee : BaseEntity
    {
        public int PersonId { get; set; }
        public string BykomUserName { get; set; }
        public int Intern { get; set; }
        public int WorkAreaId { get; set; }
        public int PositionId { get; set; }


        public virtual Person Person { get; set; }
        public virtual WorkArea WorkArea { get; set; }
        public virtual Position Position { get; set; }
        public virtual IEnumerable<Evaluation> Evaluations { get; set; }
    }
}
