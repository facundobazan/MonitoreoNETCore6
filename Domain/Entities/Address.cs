using Domain.MetaData;
using Monitoreo.Server.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table(@"Dirección")]
    [MetadataType(typeof(IAddress))]
    public class Address : BaseEntity
    {
        public int AddressTypeId { get; set; }
        public int TownshipId { get; set; }
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }


        public virtual AddressType AddressType { get; set; }
        public virtual Township Township { get; set; }
    }
}
