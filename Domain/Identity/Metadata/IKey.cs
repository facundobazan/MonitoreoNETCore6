using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.Identity.Metadata
{
    public interface IKey
    {
        [MaxLength(100)]
        public string Algorithm { get; set; }

        [DisplayName("IsX509Certificate")]
        public bool IsX509certificate { get; set; }
    }
}
