using Domain;
using Services.Abstract;
using Models;
using Mappers;
using Services;

namespace API.Controllers
{
    public class ManageContorller
    {
        private CosmeticServices CosmeticServices;
        private CosmeticExpirationServices CosmeticExpirationServices;
        private CosmeticSlowUseServices CosmeticSlowUseServices;
        private View View;

        public ManageContorller()
        {
            CosmeticServices = new CosmeticServices();
            CosmeticExpirationServices = new CosmeticExpirationServices();
            CosmeticSlowUseServices = new CosmeticSlowUseServices();
        }
        public void AddCosmetic(string name, double price, int count)
        {
            CosmeticServices.Insert(CosmeticServices.MakeCosmetic(name, price, count));
        }
        public void Display()
        {
           
        }
    }
}
