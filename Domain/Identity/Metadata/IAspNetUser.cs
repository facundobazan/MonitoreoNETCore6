using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Domain.Identity.Metadata
{
    public interface IAspNetUser
    {
        [MaxLength(256)]
        public string? UserName { get; set; }

        [NotNull]
        [MaxLength(256)]
        public string? NormalizedUserName { get; set; }

        [MaxLength(256)]
        public string? Email { get; set; }

        [MaxLength(256)]
        public string? NormalizedEmail { get; set; }
    }
}
