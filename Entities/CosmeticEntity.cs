using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Utils.Types;

namespace Entities
{
    public class CosmeticEntity : ICosmeticEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }     
        
        public DateTime ExpirationDate { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public CosmeticType CosmeticType { get; set; }
        public int Volume { get; set; }
    }
}
