using System;
using System.Collections.Generic;
using System.Linq;

namespace BakeryFreshBread
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu.ShowMainMenu();
            }
        }
    }
}
