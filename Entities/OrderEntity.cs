using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class OrderEntity
    {
        public int Id { get; set; } 
        public int CosmeticId { get; set; }
        public DateTime OrderTime { get; set; }
    }
}
