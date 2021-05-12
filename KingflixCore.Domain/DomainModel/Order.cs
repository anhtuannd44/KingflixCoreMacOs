using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KingflixCore.Domain.Enums;

namespace KingflixCore.Domain.DomainModel
{
    [Table("Order")]
    public class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }
        public string Id { get; set; }
        public string ApiOrderId { get; set; }
        public double Total { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateConfirm { get; set; }
        public string ImageConfirmPayment { get; set; }
        public OrderType Type { get; set; }
        public string CancelNote { get; set; }
        public Guid? UserUseGiftCode { get; set; } //The id of the user has the giftcode
        public string VoucherId { get; set; }
        public Guid? UserId { get; set; }
        public int? PaymentId { get; set; }
        public OrderStatus Status { get; set; }

        public virtual Payment Payment { get; set; }
        public virtual GiftCardOrder GiftCardOrder { get; set; }
        public virtual AppUser UserOrdered { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}