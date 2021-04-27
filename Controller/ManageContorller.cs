
using Services.Abstract;
using Models;
using Services;
using Data;
using System.Collections.Generic;
using Models.Abstract;
using System.Linq;
using Utils.Types;

namespace UI
{
    public class ManageContorller
    {
        private readonly UnitOfWork Data;
        private readonly ICosmeticService CosmeticService;
        private readonly IOrderService OrderService;
        public  ConsoleView View { get; set; }

        public ManageContorller(ConsoleView view)
        {
            Data = new UnitOfWork();
            CosmeticService = new CosmeticServices(Data);
            OrderService = new OrderService(Data);
            View = view;
            view.Controller = this;
        }

        
        public void AddOrder(OrderModel order)
        {
            OrderService.Insert(order);
        }
        public void AddCosmetic(CosmeticModel cosmetic)
        {
            CosmeticService.Insert(cosmetic);
        }

        public List<CosmeticModel> GetAllCosmetic()
        {
            return CosmeticService.GetAll();
        }
        public List<OrderModel> GetAllOrder()
        {
            return OrderService.GetAll();
        }
        public List<CosmeticModel> GetAllCosmeticByType(CosmeticType Type)
        {
            return CosmeticService.GetByType(Type);
        }
        public List<CosmeticModel> GetCosmeticToOdredByType(CosmeticType Type)
        {
            return CosmeticService.GetByType(Type)
                .Where(cosmetic => cosmetic.OrderNeeded() == true)
                .ToList();
        }
        public List<CosmeticModel> GetAllCosmeticToOdred()
        {
            return CosmeticService.GetAll()
                .Where(cosmetic => cosmetic.OrderNeeded() == true)
                .ToList();
        }
        public OrderModel MakeOrder(CosmeticModel cosmetic) 
        {
            return OrderService.MakeOrder(cosmetic);
        }
    }
}
