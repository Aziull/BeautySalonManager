using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Abstract
{
    public interface IRepository<TEntity>
    {
        List<TEntity> GetAll();
        TEntity GetById(int id);
        void Insert(TEntity entity);
        void Update(TEntity entityToUpdate);
        void Delete(int id);
    }
}
