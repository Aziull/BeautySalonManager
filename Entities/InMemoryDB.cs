using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utils.Types;

namespace Entities
{
    public  class InMemoryDB
    {
        public List<CosmeticEntity> CosmeticData { get; set; }
        public List<OrderEntity> OrderData { get; set; }

        private static InMemoryDB _instance;

        public static InMemoryDB Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InMemoryDB();
                return _instance;
            }
        }
        private int _cosmeticId = 5;
        public int CosmeticId
        {
            get => ++_cosmeticId;
        }
        private int _orderId = 1; 
        public int OrderId
        {
            get 
            {
                return _orderId++;
            }
        }

        private InMemoryDB() 
        {
            CosmeticData = new List<CosmeticEntity>
            {
                new CosmeticEntity {Id = 0, Name="Cosmetic Ordinary 1", Price = 100,Count=2,Volume=4,ExpirationDate = new DateTime(2021, 4,21),CosmeticType = CosmeticType.Ordinary},
                new CosmeticEntity {Id = 5, Name="Cosmetic Ordinary 2", Price = 1020,Count=7,Volume=47,ExpirationDate = new DateTime(2021, 9,21),CosmeticType = CosmeticType.Ordinary},
                new CosmeticEntity {Id = 1, Name="Cosmetic Expiration 1", Price = 1488,Count=26,Volume=46,ExpirationDate = new DateTime(2021, 4,21), CosmeticType = CosmeticType.Expiration},
                new CosmeticEntity {Id = 2, Name="Cosmetic Expiration 2", Price = 18,Count=6,Volume=0,ExpirationDate = new DateTime(2021, 4,12), CosmeticType = CosmeticType.Expiration},
                new CosmeticEntity {Id = 3, Name="Cosmetic Slow Use 1", Price = 183,Count=63,Volume=0,ExpirationDate = new DateTime(2021, 5 ,21), CosmeticType = CosmeticType.SlowUse},
                new CosmeticEntity {Id = 4, Name="Cosmetic Slow Use 2", Price = 183,Count=63,Volume=3,ExpirationDate = new DateTime(2021, 5 ,21), CosmeticType = CosmeticType.SlowUse}
            };
            OrderData = new List<OrderEntity>
            {
                new OrderEntity {Id = 0, CosmeticId= 1, OrderTime = DateTime.Now}
            };
        }
    }
}
