using Data;
using Entities;
using Mappers;
using Models;
using Models.Abstract;
using Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class OrderService : IOrderService
    {
        private UnitOfWork Data { get; set; }
        private OrderMapper OrderMapper { get; set; } = new OrderMapper();

        public OrderService(UnitOfWork context)
        {
            Data = context;
        }

        public OrderService()
        {
        }

        public void Insert(OrderModel item)
        {
            Data.Orders.Insert(OrderMapper.ToEntity(item));
        }

        public OrderModel Get(int id)
        {
            return OrderMapper.ToModel(Data.Orders.GetById(id));
        }

        public List<OrderModel> GetAll()
        {

            return Data.Orders.GetAll()
                .Select(c => OrderMapper.ToModel(c)).ToList();
        }

        public void Delete(OrderModel item)
        {
            Data.Orders.Delete(OrderMapper.ToEntity(item).Id);
        }
        public OrderModel MakeOrder(CosmeticModel cosmetic)
        {
            if (cosmetic.OrderNeeded())
            {
                return new OrderModel()
                {
                    Id = InMemoryDB.Instance.OrderId,
                    Cosmetic = cosmetic,
                    CosmeticId = cosmetic.Id,
                    OrderTime = DateTime.Now
                };
            }
            throw new Exception("make order exception");
            
        }
    }
}
