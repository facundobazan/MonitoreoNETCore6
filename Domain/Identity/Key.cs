using Domain.Identity.Metadata;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ApplicationDataContext
{
    [MetadataType(typeof(IKey))]
    [Index(nameof(Use), Name = "IX_Keys_Use")]
    public partial class Key
    {
        public string Id { get; set; } = null!;
        public int Version { get; set; }
        public DateTime Created { get; set; }
        public string? Use { get; set; }
        public string Algorithm { get; set; } = null!;
        public bool IsX509certificate { get; set; }
        public bool DataProtected { get; set; }
        public string Data { get; set; } = null!;
    }
}
