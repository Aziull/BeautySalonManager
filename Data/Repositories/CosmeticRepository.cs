using Entities;
using Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class CosmeticRepository : ICosmeticRepository
    {
        private InMemoryDB Data { get; } = InMemoryDB.Instance;
       

        public void Delete(int id)
        {
            Data.CosmeticData.Remove(Data.CosmeticData.Find(c => c.Id == id));
        }

        public List<CosmeticEntity> GetAll()
        {
            return Data.CosmeticData;
                
        }

        public CosmeticEntity GetById(int id)
        {
            return Data.CosmeticData.Find(c => c.Id == id);
        }

        public void Insert(CosmeticEntity entity)
        {
            Data.CosmeticData.Add(entity);
        }

        public void Update(CosmeticEntity entityToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
