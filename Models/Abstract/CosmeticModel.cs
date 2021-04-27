using System;
using System.Collections.Generic;
using System.Text;
using Utils.Types;

namespace Models.Abstract
{
    public abstract class CosmeticModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public abstract TimeSpan DeliveryTime { get; }
        public abstract CosmeticType CosmeticType {get;}
        public DateTime ExpirationDate { get; set; }
        public int Count { get; set; }
        public int Volume { get; set; }

        public abstract bool OrderNeeded();
    }
}
