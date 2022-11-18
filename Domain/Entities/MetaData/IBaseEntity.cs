using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Domain.Entities.MetaData
{
    public interface IBaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = @"El campo {0} es obligatorio")]
        [Display(Name = "Eliminado")]
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
    }
}
