using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TGDD.Data.Enum;
using TGDD.Data.Interfaces;
using TGDD.Infrastructure.SharedKernel;

namespace TGDD.Data.Entities
{
    [Table("ProductCategory")]
    public class ProductCategory : DomainEntity<int>, ISwichable, IDateTracking, ISortable, IHasSeoMetadata
    {
        public ProductCategory()
        {
            List<Product> Product = new List<Product>();
        }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Alias { get; set; }

        public int ParentId { get; set; }

        [StringLength(255)]
        public string SeoPageTitle { set; get; }

        [StringLength(255)]
        public string SeoAlias { set; get; }

        [StringLength(255)]
        public string SeoKeyWords { set; get; }

        [StringLength(255)]
        public string SeoDescription { set; get; }
        public int SortOrder { set; get; }
        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
        public Status Status { set; get; }

        public virtual ICollection<Product> Products { get; set; }
    }
}