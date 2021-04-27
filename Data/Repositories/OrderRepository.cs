using Entities;
using Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private InMemoryDB Data { get; } = InMemoryDB.Instance;
       

        public void Delete(int id)
        {
            Data.OrderData.Remove(Data.OrderData.Find(order => order.Id == id));
        }

        public List<OrderEntity> GetAll()
        {
            return  Data.OrderData;
        }

        public OrderEntity GetById(int id)
        {
            return Data.OrderData.Find(c => c.Id == id);
        }

        public void Insert(OrderEntity entity)
        {
            Data.OrderData.Add(entity);
        }

        public void Update(OrderEntity entityToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
