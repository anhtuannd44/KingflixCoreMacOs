// 21
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KingflixCore.Domain.DomainEntity;
using KingflixCore.Domain.Interface;

namespace KingflixCore.Domain.DomainModel
{
    [Table("BlogCategory")]
    public class BlogCategory : DomainEntity<int>, IHasSeoMetaData
    {
        public BlogCategory() { }
        public BlogCategory(string name,
            string seoPageTitle, string seoAlias, string seoMetaKeyword,
            string seoMetaDescription)
        {
            Name = name;
            SeoPageTitle = seoPageTitle;
            SeoAlias = seoAlias;
            SeoKeywords = seoMetaKeyword;
            SeoDescription = seoMetaDescription;
        }
        
        public BlogCategory(int id, string name,
             string seoAlias, string seoMetaKeyword, string seoMetaDescription)
        {
            Id = id;
            Name = name;
            SeoAlias = seoAlias;
            SeoKeywords = seoMetaKeyword;
            SeoDescription = seoMetaDescription;
        }
        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        public virtual ICollection<Blog> Blogs { set; get; }

        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }

        [MaxLength(256)]
        public string SeoPageTitle { set; get; }

        [MaxLength(256)]
        public string SeoAlias { set; get; }

        [MaxLength(256)]
        public string SeoKeywords { set; get; }

        [MaxLength(256)]
        public string SeoDescription { set; get; }
    }
}
