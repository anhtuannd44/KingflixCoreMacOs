using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KingflixCore.Domain.Enums;

namespace KingflixCore.Domain.DomainModel
{
    [Table("Support")]
    public partial class Support
    {
        public Support()
        {

        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Reply { get; set; }
        public string Image { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string ProductId { get; set; }
        public Guid UserId { get; set; }
        public SupportStatus Status { get; set; }
        public virtual AppUser UserInformation { get; set; }
        public virtual Product Product { get; set; }
        
    }
}