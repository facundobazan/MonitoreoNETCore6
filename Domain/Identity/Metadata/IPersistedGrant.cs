using System.ComponentModel.DataAnnotations;

namespace Domain.Identity.Metadata
{
    public interface IPersistedGrant
    {
        [Key]
        [MaxLength(200)]
        public string Key { get; set; }

        [MaxLength(50)]
        public string Type { get; set; }

        [MaxLength(200)]
        public string? SubjectId { get; set; }

        [MaxLength(200)]
        public string? SessionId { get; set; }

        [MaxLength(200)]
        public string ClientId { get; set; }

        [MaxLength(200)]
        public string? Description { get; set; }
    }
}
