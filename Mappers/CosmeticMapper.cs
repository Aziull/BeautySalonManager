using Entities;
using Models;
using Models.Abstract;
using Models.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mappers
{
    public class CosmeticMapper
    {
        public CosmeticEntity ToEntity(CosmeticModel cosmetic )
        {
            return new CosmeticEntity {
                Id = cosmetic.Id,
                Name = cosmetic.Name,
                Price = cosmetic.Price,
                Count = cosmetic.Count,
                CosmeticType = cosmetic.CosmeticType,
                Volume = cosmetic.Volume,
                ExpirationDate = cosmetic.ExpirationDate
            };
        }
 
        public CosmeticModel ToModel(CosmeticEntity cosmetic)
        {
            var factory = new CosmeticFactory();
            var cosmeticModel = factory.MakeCosmetic(cosmetic.CosmeticType);

            cosmeticModel.Id = cosmetic.Id;
            cosmeticModel.Name = cosmetic.Name;
            cosmeticModel.Price = cosmetic.Price;
            cosmeticModel.Count = cosmetic.Count;
            cosmeticModel.Volume = cosmetic.Volume;
            cosmeticModel.ExpirationDate = cosmetic.ExpirationDate;
            
            
            return cosmeticModel;
        }
    }
}
