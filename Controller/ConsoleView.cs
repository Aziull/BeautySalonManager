using Entities;
using Models;
using Models.Abstract;
using Models.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Types;

namespace UI
{
    public class ConsoleView
    {
        public ManageContorller Controller { get; set; }

        public List<string> MainMenuOptions { get; set; }
        public List<string> CosmeticMenuOptions { get; set; }
        public List<string> CosmeticExpirationMenuOptions { get; set; }
        public List<string> CosmeticSlowUseMenuOptions { get; set; }
        public List<string> CosmeticAllMenuOptions { get; set; }
        public List<string> OrderMenuOptions { get; set; }

        public ConsoleView()
        {
            MainMenuOptions = new List<string>(4)
            {
                "1)Add Cosmetic.",
                "2)Cosmetic ordinary menu.",
                "3)Cosmetic with expiration menu.",
                "4)Cosmetic slow use menu.",
                "5)All cosmetic menu.",
                "6)Order menu.",
                "7)Exit."
            };

            CosmeticMenuOptions = new List<string>(2)
            {
                "1)View ordinary cosmetic.",
                "2)View ordinary cosmetic to order.",
                "3)Return to previous menu."
            };

            CosmeticExpirationMenuOptions = new List<string>(3)
            {
                "1)View cosmetic expiration.",
                "2)View cosmetic expiration to order.",
                "3)Return to previous menu."
            };

            CosmeticSlowUseMenuOptions = new List<string>(3)
            {
                "1)View cosmetic slow use.",
                "2)View slow use cosmetic to order.",
                "3)Return to previous menu."
            };
            
            CosmeticAllMenuOptions = new List<string>(3)
            {
                "1)View all cosmetic.",
                "2)View all cosmetic to order.",
                "3)Return to previous menu."
            };
            OrderMenuOptions = new List<string>(3)
            {
                "1)View all orders.",
                "2)Make Order.",
                "3)Return to previous menu."
            };
        }


        public void DisplayCosmetic(CosmeticModel cosmetic)
        {
            Console.WriteLine($"Name - {cosmetic.Name} \n" +
                              $"Price - {cosmetic.Price} \n" +
                              $"Count - {cosmetic.Count} \n");
        }
        public void DisplayCosmeticExpirations(CosmeticModel cosmeticExpiration)
        {
            Console.WriteLine($"Name - {cosmeticExpiration.Name} \n" +
                              $"Price - {cosmeticExpiration.Price} \n" +
                              $"Expiration date - {cosmeticExpiration.ExpirationDate} \n");
        }
        public void DisplayCosmeticSlowUse(CosmeticModel cosmeticSlowUse)
        {
            Console.WriteLine($"Name - {cosmeticSlowUse.Name} \n" +
                              $"Price - {cosmeticSlowUse.Price} \n" +
                              $"Capacity - {cosmeticSlowUse.Volume} \n");
        }

        public void Start()
        {
            Console.WriteLine($"Cosmetic DB\n");
            
            while (true)
            {
                PrintMenuItems(MainMenuOptions, "Main");
                ConsoleKey key = Console.ReadKey().Key;
                Console.WriteLine();
                switch (key) {
                    case ConsoleKey.D1:
                        AddCosmeticMenu();
                        break;
                    case ConsoleKey.D2:
                        CosmeticMenu();
                        break;
                    case ConsoleKey.D3:
                        CosmeticExpirationMenu();
                        break;
                    case ConsoleKey.D4:
                        CosmeticSlowUseMenu();
                        break;
                    case ConsoleKey.D5:
                        CosmeticAllMenu();
                        break;
                    case ConsoleKey.D6:
                        OrderMenu();
                        break;
                    case ConsoleKey.D7:
                        return;
                }
                Console.WriteLine();
            }
        }
        void AddCosmeticMenu()
        {
            Console.Write("Enter cosmetic Type: ");
            string type = Console.ReadLine();
            Console.Write("Enter cosmetic Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter cosmetic Price: ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter cosmetic ExpirationDate: ");
            DateTime expirationDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Enter cosmetic Count: ");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter cosmetic Volume: ");
            int volume = Convert.ToInt32(Console.ReadLine());

            CosmeticFactory CosmeticFactory = new CosmeticFactory();

            var cosmetic = CosmeticFactory.MakeCosmetic((CosmeticType)Enum.Parse(typeof(CosmeticType), type));
            cosmetic.Id = InMemoryDB.Instance.CosmeticId;
            cosmetic.Name = name;
            cosmetic.Price = price;
            cosmetic.Count = count;
            cosmetic.Volume = volume;
            cosmetic.ExpirationDate = expirationDate;
            Controller.AddCosmetic(cosmetic);
        }   
        void CosmeticMenu()
        {
             PrintMenuItems(CosmeticMenuOptions, "Ordinary Cosmecic");
            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                Console.WriteLine();
                switch (key)
                {
                    case ConsoleKey.D1:
                        Controller.GetAllCosmeticByType(CosmeticType.Ordinary).ForEach(Console.WriteLine);

                        break;
                    case ConsoleKey.D2:
                        Controller.GetCosmeticToOdredByType(CosmeticType.Ordinary).ForEach(Console.WriteLine);
                        break;
                    case ConsoleKey.D3:
                        return;
                }
            }
        }
        void CosmeticExpirationMenu()
        {
            PrintMenuItems(CosmeticExpirationMenuOptions, "Cosmetic Expiration");
            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                Console.WriteLine();
                switch (key)
                {
                    case ConsoleKey.D1:
                        Controller.GetAllCosmeticByType(CosmeticType.Expiration).ForEach(Console.WriteLine);
                        PrintMenuItems(CosmeticExpirationMenuOptions, "Cosmetic Expiration");
                        break;
                    case ConsoleKey.D2:
                        Controller.GetCosmeticToOdredByType(CosmeticType.Expiration).ForEach(Console.WriteLine);
                        PrintMenuItems(CosmeticExpirationMenuOptions, "Cosmetic Expiration");
                        break;
                    case ConsoleKey.D3:
                        return;
                }
            }
        }
        void CosmeticSlowUseMenu()
        {
            PrintMenuItems(CosmeticMenuOptions, " Cosmetic Slow Use");
            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                Console.WriteLine();
                switch (key)
                {
                    case ConsoleKey.D1:
                        Controller.GetAllCosmeticByType(CosmeticType.SlowUse).ForEach(Console.WriteLine);
                        PrintMenuItems(CosmeticMenuOptions, " Cosmetic Slow Use");
                        break;
                    case ConsoleKey.D2:
                        Controller.GetCosmeticToOdredByType(CosmeticType.SlowUse).ForEach(Console.WriteLine);
                        PrintMenuItems(CosmeticMenuOptions, " Cosmetic Slow Use");
                        break;
                    case ConsoleKey.D3:
                        return;
                }
            }
        }
        void CosmeticAllMenu()
        {
            PrintMenuItems(CosmeticAllMenuOptions, "All Cosmetic");
            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                Console.WriteLine();
                switch (key)
                {
                    case ConsoleKey.D1:
                        Controller.GetAllCosmetic().ForEach(Console.WriteLine);
                        PrintMenuItems(CosmeticAllMenuOptions, "All Cosmetic");
                        break;
                    case ConsoleKey.D2:
                        Controller.GetAllCosmeticToOdred().ForEach(Console.WriteLine);
                        PrintMenuItems(CosmeticAllMenuOptions, "All Cosmetic");
                        break;
                    case ConsoleKey.D3:
                        return;
                }
            }
        }

        void OrderMenu()
        {
            PrintMenuItems(OrderMenuOptions, "Order Menu");
            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                Console.WriteLine();
                switch (key)
                {
                    case ConsoleKey.D1:
                        Controller.GetAllOrder().ForEach(Console.WriteLine);
                        PrintMenuItems(OrderMenuOptions, "Order Menu");
                        break;
                    case ConsoleKey.D2:
                        Controller.GetAllCosmeticToOdred().Select(c => Controller.MakeOrder(c)).ToList().ForEach(Controller.AddOrder);
                         PrintMenuItems(OrderMenuOptions, "Order Menu");
                        break;
                    case ConsoleKey.D3:
                        return;
                }
            }
        }

        public void PrintMenuItems(List<string> items, string menuName)
        {
            Console.WriteLine($"----------{menuName} Menu-----------");
            items.ForEach(Console.WriteLine);
        }

    }
}
