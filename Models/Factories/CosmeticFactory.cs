using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Utils.Types;

namespace Models.Factories
{
    public class CosmeticFactory
    {
        public CosmeticModel MakeCosmetic(CosmeticType type)
        {
            switch (type)
            {
                case CosmeticType.Ordinary:
                    return new OrdinaryCosmeticModel();
                case CosmeticType.Expiration:
                    return new ExpirationDateCosmeticModel();
                case CosmeticType.SlowUse:
                    return new SlowUseCosmeticModel();
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}
