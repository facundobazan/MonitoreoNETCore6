using System.ComponentModel.DataAnnotations;

namespace Monitoreo.Server.Models
{
    public class WorkArea : BaseEntity
    {
        [Required]
        [Display(Name = "Area")]
        public string AreaName { get; set; }

        public virtual IEnumerable<Employee> Employees { get; set;}
    }
}
