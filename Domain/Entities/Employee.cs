using Domain.MetaData;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monitoreo.Server.Models
{
    [Table("Empleado")]
    [MetadataType(typeof(IEmployee))]
    [Index(nameof(PersonId), nameof(BykomUserName), Name = "Index_PersonId_BykomUserName_Employee", IsUnique = true)]
    //[Index(nameof(BykomUserName), Name = "Index_PersonId_BykomUserName_Employee", IsUnique = true)]
    public class Employee : BaseEntity
    {
        public int PersonId { get; set; }
        public string BykomUserName { get; set; }
        public int Intern { get; set; }
        public int WorkAreaId { get; set; }
        public int PositionId { get; set; }


        public virtual Person Person { get; set; }
        public virtual WorkArea WorkArea { get; set; }
        public virtual WorkPosition Position { get; set; }
        public virtual ICollection<Evaluation> Evaluations { get; set; }
    }
}
