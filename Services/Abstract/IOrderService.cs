using Models;
using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Abstract
{
    public interface IOrderService : ICosmeticService<OrderModel>
    {
        OrderModel MakeOrder(CosmeticModel cosmetic);
    }
}
