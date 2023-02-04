using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryFreshBread
{
    class MainMenu
    {
        public static bool ShowMainMenu()
        {
            
            Console.Clear();
            Console.WriteLine("BAKERY FRESH BREAD");
            Console.WriteLine("------------------");
            Console.WriteLine("1. Main Shop");
            Console.WriteLine("2. Second Shop");
            Console.Write("\r\nSelect an option: ");

            switch (Utility.ValidateNumericInput())
            {
                case 1:
                    MainOffice.ShowOfficeMenu();
                    return true;
                case 2:
                    SecondOffice.ShowOfficeMenu();
                    return true;
                default:
                    return true;
            }
        }
    }
}
