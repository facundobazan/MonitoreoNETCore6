using ApplicationDataContext;
using Domain.Entities.MetaData;
using Microsoft.EntityFrameworkCore;
using Monitoreo.Server.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("Provincia")]
    [MetadataType(typeof(IProvince))]
    [Index(nameof(CountryId), nameof(ProvinceName), Name = "Index_CountryId_ProvinceName_Province", IsUnique = true)]
    //[Index(nameof(ProvinceName), Name = "Index_CountryId_ProvinceName_Province", IsUnique = true)]
    public class Province : BaseEntity
    {
        public int CountryId { get; set; }
        public string ProvinceName { get; set; }


        public virtual Country Country { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}
