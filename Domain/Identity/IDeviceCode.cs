using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.Identity
{
    public interface IDeviceCode
    {
        [Key]
        [MaxLength(200)]
        public string UserCode { get; set; }

        [MaxLength(200)]
        [DisplayName("DeviceCode")]

        public string DeviceCode1 { get; set; }

        [MaxLength(100)]
        public string? SubjectId { get; set; }

        [MaxLength(100)]
        public string? SessionId { get; set; }

        [MaxLength(200)]
        public string ClientId { get; set; }

        [MaxLength(200)]
        public string? Description { get; set; }

        public DateTime CreationTime { get; set; }

        public DateTime Expiration { get; set; }

        public string Data { get; set; }
    }
}
