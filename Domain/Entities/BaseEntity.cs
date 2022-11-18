using Domain.Entities.MetaData;
using System.ComponentModel.DataAnnotations;

namespace Monitoreo.Server.Models
{
    [MetadataType(typeof(IBaseEntity))]
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
