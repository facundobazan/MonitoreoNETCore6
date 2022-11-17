using Domain.Entities;
using Domain.MetaData;
using Microsoft.EntityFrameworkCore;
using Monitoreo.Server.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationDataContext
{
    [Table(@"País")]
    [MetadataType(typeof(ICountry))]
    [Index(nameof(CountryName), IsUnique = true)]
    public class Country : BaseEntity
    {
        public string CountryName { get; set; }


        public virtual ICollection<Province> Provinces { get; set; }
    }
}
