using Domain.MetaData;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monitoreo.Server.Models
{
    [Table("Persona")]
    [MetadataType(typeof(IPerson))]
    public class Person : BaseEntity
    {
        public string FistName { get; set; }
        public string LastName { get; set; }

        //public virtual Employee Employee { get; set; }
    }
}
