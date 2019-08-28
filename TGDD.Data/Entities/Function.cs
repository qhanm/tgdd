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
    [Table("Function")]
    public class Function : DomainEntity<string>, ISwichable, ISortable
    {
        public Function() { }

        public Function(string id, string name, string url, string parentId, string iconCss, Status status, int sortOrder)
        {
            Id = id;
            Name = name;
            Url = url;
            ParentId = parentId;
            IconCss = iconCss;
            Status = status;
            SortOrder = sortOrder;
        }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(128)]
        public string Url { get; set; }

        [StringLength(128)]
        public string ParentId { get; set; }

        public string IconCss { get; set; }


        public int SortOrder { set; get; }
        public Status Status { set; get; }
    }
}
