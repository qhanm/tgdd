using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TGDD.Infrastructure.SharedKernel;

namespace TGDD.Data.Entities
{
    [Table("Size")]
    public class Size : DomainEntity<int>
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}