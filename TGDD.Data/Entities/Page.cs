using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TGDD.Data.Enum;
using TGDD.Data.Interfaces;
using TGDD.Infrastructure.SharedKernel;

namespace TGDD.Data.Entities
{
    [Table("Page")]
    public class Page : DomainEntity<int>, ISwichable
    {
        public Page() { }

        public Page(int id, string name, string alias, string desciption, string content, Status status)
        {
            Id = id;
            Name = name;
            Desciption = desciption;
            Alias = alias;
            Content = content;
            Status = status;
        }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public string Desciption { get; set; }

        public string Content { get; set; }

        [Required]
        [StringLength(255)]
        public string Alias { get; set; }

        public Status Status { get; set; }
    }
}
