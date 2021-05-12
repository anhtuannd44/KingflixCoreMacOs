using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KingflixCore.Domain.DomainModel
{
    [Table("OrderDetails")]
    public class OrderDetails
    {
        public OrderDetails()
        {

        }
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string ImageId { get; set; }
        public double Month { get; set; }
        public int Count { get; set; }
        public string UserAccount { get; set; }
        public string UserPassword { get; set; }
        public bool IsGuarantee { get; set; }
        public bool IsKingflixAccount { get; set; }
        public string CategoryId { get; set; } //ForeignKey
        public string OrderId { get; set; } //ForeignKey
        public string Price {get;set;}
        public virtual Order Order { get; set; }
        public virtual Category Category { get; set; }

    }
}