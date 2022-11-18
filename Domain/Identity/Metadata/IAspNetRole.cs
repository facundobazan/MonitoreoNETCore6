using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Domain.Identity.Metadata
{
    public interface IAspNetRole
    {
        [MaxLength(256)]
        public string? Name { get; set; }

        [NotNull]
        [MaxLength(256)]
        public string? NormalizedName { get; set; }

    }
}
