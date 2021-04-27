using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public int CosmeticId { get; set; }
        public CosmeticModel Cosmetic { get; set; }
        public DateTime OrderTime { get; set; }
        public TimeSpan DeliveryTime { get => Cosmetic.DeliveryTime;}
        public override string ToString()
        {
            return "Order with id: " + Id + " with cosmetic id: " + CosmeticId + " will be delivered in " + DeliveryTime.Days + " days and " + DeliveryTime.Hours + " hours";
        }
    }
}
