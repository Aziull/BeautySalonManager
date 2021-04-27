using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Utils.Types;

namespace Models
{
    public class ExpirationDateCosmeticModel : CosmeticModel
    {
       

        public override TimeSpan DeliveryTime => new TimeSpan(1,4,8,8);

        public override CosmeticType CosmeticType => CosmeticType.Expiration;

       

        public override bool OrderNeeded()
        {
            return DateTime.Now > ExpirationDate;
        }
        public override string ToString()
        {
            return "Expiraton Date Cosmetic Description: \n \t Id " + Id + " Name " + Name + " Expiration Date " + ExpirationDate;
        }
    }
}
