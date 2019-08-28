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
    [Table("Blog")]
    public class Blog : DomainEntity<int>, ISwichable, IHasSeoMetadata, IDateTracking
    {
        public Blog() { }

        public Blog( string name, string description, string content, bool? hotFlag, bool? homeFlag, int? viewCount, string tag, Status status, string seoPageTile, string seoAlias, string seoKeywords, string seoDescription)
        {
            Name = name;
            Description = description;
            Content = content;
            HotFlag = hotFlag;
            HomeFlag = homeFlag;
            ViewCount = viewCount;
            Status = status;
            SeoPageTitle = seoPageTile;
            SeoKeyWords = seoKeywords;
            SeoDescription = SeoDescription;
            SeoDescription = seoDescription;
        }

        public Blog(int id, string name, string description, string content, bool? hotFlag, bool? homeFlag, int? viewCount, string tag, Status status, string seoPageTile, string seoAlias, string seoKeywords, string seoDescription)
        {
            Id = id;
            Name = name;
            Description = description;
            Content = content;
            HotFlag = hotFlag;
            HomeFlag = homeFlag;
            ViewCount = viewCount;
            Status = status;
            SeoPageTitle = seoPageTile;
            SeoKeyWords = seoKeywords;
            SeoDescription = SeoDescription;
            SeoDescription = seoDescription;
        }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public string Content { get; set; }

        public bool? HotFlag { get; set; }

        public bool? HomeFlag { get; set; }

        public int? ViewCount { get; set; }

        public string Tag { get; set; }

        public virtual ICollection<BlogTag> BlogTags { get; set; }

        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
        public string SeoPageTitle { set; get; }
        public string SeoAlias { set; get; }
        public string SeoKeyWords { set; get; }
        public string SeoDescription { set; get; }

        [DefaultValue(Status.Active)]
        public Status Status { set; get; }
    }
}
