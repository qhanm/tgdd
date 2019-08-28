using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TGDD.Data.Enum;
using TGDD.Data.Interfaces;
using TGDD.Infrastructure.SharedKernel;

namespace TGDD.Data.Entities
{
    [Table("SystemConfigs")]
    public class SystemConfig : DomainEntity<string>, ISwichable
    {
        [Required]
        [StringLength(128)]
        public string Vaule1 { get; set; }
        public string Vaule2 { get; set; }
        public string Vaule3 { get; set; }
        public string Vaule4 { get; set; }
        public string Vaule5 { get; set; }
        public string Vaule6 { get; set; }
        public Status Status { get; set; }
    }
}