using Domain.MetaData;
using Microsoft.EntityFrameworkCore;
using Monitoreo.Server.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("Ciudad")]
    [MetadataType(typeof(ICity))]
    [Index(nameof(ProvinceId), nameof(CityName), Name = "Index_ProvinceId_CityName_City", IsUnique = true)]
    //[Index(nameof(CityName), Name = "Index_ProvinceId_CityName_City", IsUnique = true)]
    public class City : BaseEntity
    {
        public int ProvinceId { get; set; }
        public string CityName { get; set; }


        public virtual Province Province { get; set; }
        public virtual ICollection<Township> Townships { get; set; }
    }
}
