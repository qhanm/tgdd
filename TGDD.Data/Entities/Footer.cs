using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TGDD.Infrastructure.SharedKernel;

namespace TGDD.Data.Entities
{
    [Table("Footer")]
    public class Footer : DomainEntity<string>
    {
  
        public string Content { get; set; }
    }
}
