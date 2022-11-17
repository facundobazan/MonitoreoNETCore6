using Domain.MetaData;
using Microsoft.EntityFrameworkCore;
using Monitoreo.Server.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table(@"Tipo de dirección")]
    [MetadataType(typeof(IAddressType))]
    [Index(nameof(AddressTypeName), IsUnique = true)]
    public class AddressType : BaseEntity
    {
        public string AddressTypeName { get; set; }
        public string Description { get; set; }


        public virtual ICollection<Address> Addresses { get; set; }
    }
}
