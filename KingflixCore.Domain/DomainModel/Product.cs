using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KingflixCore.Domain.Enums;

namespace KingflixCore.Domain.DomainModel
{
    [Table("Product")]
    public class Product
    {
        public Product()
        {
            Profiles = new HashSet<Profile>();
            Supports = new HashSet<Support>();
        }

        public string Id { get; set; }
        public string Password { get; set; }
        public DateTime DateEnd { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public Cycle Cycle { get; set; }
        public string Cover { get; set; }
        public int GroupId { get; set; }
        public string ReplaceProductId { get; set; }
        public string CategoryId { get; set; }
        public virtual ProductStatus Status { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Profile> Profiles { get; set; }
        public virtual ICollection<Support> Supports { get; set; }
    }
}