using Entities;
using System;
using UI;

namespace BeautySalon
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleView consoleView = new ConsoleView();
            ManageContorller manageContorller = new ManageContorller(consoleView);
            manageContorller.View.Start();



        }
    }
}
