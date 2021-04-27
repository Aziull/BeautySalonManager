using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utils.Types;

namespace Models
{
    public class OrdinaryCosmeticModel : CosmeticModel
    {
        public override TimeSpan DeliveryTime => new TimeSpan(3, 2, 2, 8);

        public override CosmeticType CosmeticType => CosmeticType.Ordinary;
        public override bool OrderNeeded() => Count < 5;
            
            
        public override string ToString()
        {
            return "Ordinary Cosmetic Description: \n \t Id " + Id + " Name " + Name + " Count " + Count;
        }
    }
}
