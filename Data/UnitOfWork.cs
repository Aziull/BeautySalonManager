using Data.Repositories;
using Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class UnitOfWork
    {
        public ICosmeticRepository Cosmetics {get; set;}
        public IOrderRepository Orders { get; set; }
        
        public UnitOfWork()
        {
            Cosmetics = new CosmeticRepository();
            Orders = new OrderRepository();
        }
    }
}
