using Entities;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mappers
{
    public class OrderMapper
    {
        CosmeticMapper CosmeticMapper = new CosmeticMapper();
        public OrderEntity ToEntity(OrderModel order)
        {
            return new OrderEntity
            {
                Id = order.Id,
                CosmeticId = order.CosmeticId,
                OrderTime = order.OrderTime
            };
        }

        public OrderModel ToModel(OrderEntity order)
        {
            return new OrderModel
            {
                Id = order.Id,
                CosmeticId = order.CosmeticId,
                Cosmetic =CosmeticMapper.ToModel( InMemoryDB.Instance.CosmeticData.Find(cosmetic => cosmetic.Id == order.CosmeticId)),
                OrderTime = order.OrderTime
            };
        }
    }
}
