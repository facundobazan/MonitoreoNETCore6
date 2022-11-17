using Domain.MetaData;
using Microsoft.EntityFrameworkCore;
using Monitoreo.Server.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("Municipio")]
    [MetadataType(typeof(ITownship))]
    [Index(nameof(CityId), nameof(TownshipName), Name = "Index_CityId_TownshipName_Township", IsUnique = true)]
    //[Index(nameof(TownshipName), Name = "Index_CityId_TownshipName_Township", IsUnique = true)]
    public class Township : BaseEntity
    {
        public int CityId { get; set; }
        public string TownshipName { get; set; }


        public virtual City City { get; set; }
        public virtual ICollection<Township> Towns { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
