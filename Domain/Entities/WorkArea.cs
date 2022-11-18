using Domain.Entities.MetaData;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monitoreo.Server.Models
{
    [Table(@"Área de trabajo")]
    [MetadataType(typeof(IWorkArea))]
    [Index(nameof(AreaName), IsUnique = true)]
    public class WorkArea : BaseEntity
    {
        public string AreaName { get; set; }


        public virtual ICollection<Employee> Employees { get; set; }
    }
}
