
using Data;
using Mappers;
using Models;
using Models.Abstract;
using Services.Abstract;
using System.Collections.Generic;
using System.Linq;
using Utils.Types;

namespace Services
{
    public class CosmeticServices : ICosmeticService
    {
        private UnitOfWork Data { get; set; }
        private CosmeticMapper cosmeticMapper { get; set; } = new CosmeticMapper();
       
        public CosmeticServices(UnitOfWork context)
        {
            Data = context;
        }

        public CosmeticServices()
        {
        }

        public void Insert(CosmeticModel item)
        {
            Data.Cosmetics.Insert(cosmeticMapper.ToEntity(item));
        }

        public CosmeticModel Get(int id)
        {
             return cosmeticMapper.ToModel(Data.Cosmetics.GetById(id));
        }

        public List<CosmeticModel> GetAll()
        {
            return Data.Cosmetics.GetAll()
                .Select(c => cosmeticMapper.ToModel(c)).ToList();
        }
      

        public void Delete(CosmeticModel item)
        {
            Data.Cosmetics.Delete(cosmeticMapper.ToEntity(item).Id);
        }

        public List<CosmeticModel> GetByType(CosmeticType Type)
        {
            return GetAll().Where(cosmetic => cosmetic.CosmeticType == Type).ToList();
        }
    }
}
