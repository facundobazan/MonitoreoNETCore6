using Domain.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApplicationDataContext
{
    [MetadataType(typeof(IDeviceCode))]
    [Index(nameof(DeviceCode1), Name = "IX_DeviceCodes_DeviceCode", IsUnique = true)]
    [Index(nameof(Expiration), Name = "IX_DeviceCodes_Expiration")]
    public partial class DeviceCode
    {
        public string UserCode { get; set; } = null!;
        public string DeviceCode1 { get; set; } = null!;
        public string? SubjectId { get; set; }
        public string? SessionId { get; set; }
        public string ClientId { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime Expiration { get; set; }
        public string Data { get; set; } = null!;
    }
}
