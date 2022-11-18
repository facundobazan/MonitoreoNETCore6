using Domain.Identity.Metadata;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApplicationDataContext
{
    [MetadataType(typeof(IPersistedGrant))]
    [Index(nameof(ConsumedTime), Name = "IX_PersistedGrants_ConsumedTime")]
    [Index(nameof(Expiration), Name = "IX_PersistedGrants_Expiration")]
    /*[Index(nameof(SubjectId), Name = "IX_PersistedGrants_SubjectId_ClientId_Type")]
    [Index(nameof(ClientId), Name = "IX_PersistedGrants_SubjectId_ClientId_Type")]
    [Index(nameof(Type), Name = "IX_PersistedGrants_SubjectId_ClientId_Type")]
    [Index(nameof(SubjectId), Name = "IX_PersistedGrants_SubjectId_SessionId_Type")]
    [Index(nameof(SessionId), Name = "IX_PersistedGrants_SubjectId_SessionId_Type")]
    [Index(nameof(Type), Name = "IX_PersistedGrants_SubjectId_SessionId_Type")]*/
    public partial class PersistedGrant
    {
        public string Key { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string? SubjectId { get; set; }
        public string? SessionId { get; set; }
        public string ClientId { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? Expiration { get; set; }
        public DateTime? ConsumedTime { get; set; }
        public string Data { get; set; } = null!;
    }
}
