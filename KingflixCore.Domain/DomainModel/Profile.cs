using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KingflixCore.Domain.DomainModel
{
    [Table("Profile")]
    public class Profile
    {

        public Profile()
        {

        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string PinCode { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string Note { get; set; }
        public string ProductId { get; set; }
        public Guid? UserId { get; set; }
        public virtual AppUser UserInformation { get; set; }
        public virtual Product Product { get; set; }
    }
}