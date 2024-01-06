using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Catalog.Core.Entities
{
    [Table("Identification")]
    public class BaseEntity
    {
        [Key]
        public int Id { get; set;  }
    }
}
