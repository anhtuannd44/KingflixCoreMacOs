using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KingflixCore.Domain.Enums;
using KingflixCore.Domain.Interfaces;

namespace KingflixCore.Domain.DomainModel
{
    [Table("Blogs")]
    public class Blog : IDateTracking
    {
        public Blog()
        {

        }

        [Key]
        public int Id { get; set; }
        public string Title { set; get; }
        public string Alias { set; get; }
        public string Cover { set; get; }
        public string Description { set; get; }
        public string Content { set; get; }
        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
        public string SeoKeywords { set; get; }
        public string SeoDescription { set; get; }
        public Status Status { set; get; }
        public int BlogCategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual BlogCategory BlogCategory { get; set; }
    }
}
