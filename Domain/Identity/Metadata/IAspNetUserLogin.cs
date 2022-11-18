using System.ComponentModel.DataAnnotations;

namespace Domain.Identity.Metadata
{
    public interface IAspNetUserLogin
    {
        [Key]
        [MaxLength(256)]
        public string LoginProvider { get; set; }

        [MaxLength(256)]
        public string ProviderKey { get; set; }
    }
}
