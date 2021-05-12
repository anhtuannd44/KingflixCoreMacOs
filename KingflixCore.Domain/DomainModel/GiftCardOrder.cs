using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KingflixCore.Domain.Enums;

namespace KingflixCore.Domain.DomainModel
{
    [Table("GiftCardOrder")]
    public class GiftCardOrder
    {
        public GiftCardOrder()
        {
         
        }
        public string Id { get; set; }
        public int? CardTemplate { get; set; }
        public bool? IsDelivery { get; set; }
        public string DeliveryName { get; set; }
        public string DeliveryAddress { get; set; }
        public string DeliveryPhoneNumber { get; set; }
        public DateTime? DeliveryTime { get; set; }
        public string DeliveryMessage { get; set; }
        public string OrderId {get;set;}
        public virtual Order Order { get; set; }
    }
}