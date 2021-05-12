using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KingflixCore.Domain.Enums;

namespace KingflixCore.Domain.DomainModel
{
    [Table("Payment")]
    public partial class Payment
    {
        public Payment()
        {
            Orders = new HashSet<Order>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string AccountAddress { get; set; }
        public PaymentType Type { get; set; }
        public string Cover { get; set; }
        public string QRImage { get; set; }
        public Status Status { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}