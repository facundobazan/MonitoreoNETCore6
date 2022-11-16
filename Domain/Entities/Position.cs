using System.ComponentModel.DataAnnotations;

namespace Monitoreo.Server.Models
{
    public class Position
    {
        [Required]
        [Display(Name = "Cargo")]
        public string PositionName { get; set; }

        public virtual IEnumerable<Employee> Employees { get; set; }
    }
}