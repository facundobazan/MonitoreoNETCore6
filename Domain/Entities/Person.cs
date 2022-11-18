using Domain.Entities;
using Domain.Entities.MetaData;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Monitoreo.Server.Models
{
    [Table("Persona")]
    [MetadataType(typeof(IPerson))]
    //[Index(nameof(FirstName), Name = "Index_FirstName_LastName_Person", IsUnique = true)]
    //[Index(nameof(LastName), Name = "Index_FirstName_LastName_Person", IsUnique = true)]
    public class Person : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AddressId { get; set; }


        public virtual ICollection<Employee> Employees { get; set; }
        public virtual Address Address { get; set; }
    }
}
