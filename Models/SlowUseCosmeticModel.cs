using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Utils.Types;

namespace Models
{
    public class SlowUseCosmeticModel : CosmeticModel
    {
        public override TimeSpan DeliveryTime => new TimeSpan(5, 0, 5, 1);

        public override CosmeticType CosmeticType => CosmeticType.SlowUse;

        public override bool OrderNeeded() => Volume == 0;
        public override string ToString()
        {
            return "Slow Use Cosmetic Description: \n \t Id " + Id + " Name " + Name + " Volume " + Volume;
        }

    }
}
