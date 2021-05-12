// 13
using System;
using System.Collections.Generic;
using KingflixCore.Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace KingflixCore.Domain.DomainModel
{
    public class AppUser : IdentityUser<Guid>
    {
        public AppUser()
        {
            Profiles = new HashSet<Profile>();
            Supports = new HashSet<Support>();
            Orders = new HashSet<Order>();
        }
        public AppUser(Guid id, string fullName, string userName,
            string email, string phoneNumber, string avatar, Status status)
        {
            Id = id;
            FullName = fullName;
            UserName = userName;
            Email = email;
            PhoneNumber = phoneNumber;
            Avatar = avatar;
            Status = status;
        }
        public string FullName { get; set; }

        public DateTime? BirthDay { set; get; }

        public decimal Balance { get; set; }

        public string Avatar { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public Status Status { get; set; }

        public virtual ICollection<Profile> Profiles { get; set; }
        public virtual ICollection<Support> Supports { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
