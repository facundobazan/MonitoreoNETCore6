using Domain.MetaData;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monitoreo.Server.Models
{
    [Table("Puesto de trabajo")]
    [MetadataType(typeof(IWorkPosition))]
    [Index(nameof(WorkPositionName), IsUnique = true)]
    public class WorkPosition : BaseEntity
    {
        public string WorkPositionName { get; set; }


        public virtual ICollection<Employee> Employees { get; set; }
    }
}