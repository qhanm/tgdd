using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TGDD.Data.Enum;
using TGDD.Data.Interfaces;
using TGDD.Infrastructure.SharedKernel;

namespace TGDD.Data.Entities
{
    [Table("Product")]
    public class Product : DomainEntity<int>, ISwichable, IDateTracking, IHasSeoMetadata, ISortable
    {
        [Required]
        [StringLength(255)]
        public string Name { set; get; }

        [Required]
        public int CategoryId { set; get; }

        public string Image { set; get; }

        [Required]
        [DefaultValue(0)]
        public decimal Price { set; get; }

        public decimal? PromotionPrice { set; get; }

        public decimal OriginalPrice { set; get; }

        [StringLength(6)]
        public string Description { set; get; }

        public string Content { set; get; }

        public bool? HomeFlag { set; get; }

        public bool? HotFlag { set; get; }

        public int? ViewCount { set; get; }

        [StringLength(255)]
        public string Tags { set; get; }

        public string Unit { set; get; }

        public string Sku { set; get; }

        public Status Status { set; get; }
        public int SortOrder { set; get; }
        public string SeoPageTitle { set; get; }
        public string SeoAlias { set; get; }
        public string SeoKeyWords { set; get; }
        public string SeoDescription { set; get; }
        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }

        [ForeignKey("CategoryId")]
        public virtual ProductCategory ProductCategory { get; set; }
    }
}
