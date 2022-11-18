using System.ComponentModel.DataAnnotations;

namespace Domain.Identity.Metadata
{
    public interface IAspNetUserToken
    {
        [Key]
        public string UserId { get; set; }

        [Key]
        [MaxLength(128)]
        public string LoginProvider { get; set; }

        [Key]
        [MaxLength(128)]
        public string Name { get; set; }
    }
}
