using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace BakeryFreshBread
{
    class SecondOffice
    {
        private static int maxOrders2ndOffice = 100;
        private static List<Baguette> baguetteList = new List<Baguette>();
        private static List<WhiteBread> whiteBreadList = new List<WhiteBread>();
        private static List<HamburguerBread> hamburguerBreadList = new List<HamburguerBread>();
        private static int totalBaguetteQuantity;
        private static int totalWhiteBreadQuantity;
        public static int totalHamburguerBreadQuantity;
       
        public static bool ShowOfficeMenu()
        {
            Console.Clear();
            Console.WriteLine("SECOND BAKERY");
            Console.WriteLine("------------------");
            Console.WriteLine("1. Add Order");
            Console.WriteLine("2. Prepare All Orders");
            Console.WriteLine("3. Back to Main Menu");
            Console.Write("\r\nSelect an option: ");

            switch (Utility.ValidateNumericInput())
            {
                case 1:
                    ShowAddOrdersScreen();
                    return true;
                case 2:
                    ShowPrepareOrdersScreen();
                    return true;
                case 3:
                    MainMenu.ShowMainMenu();
                    return true;
                default:
                    return true;
            }
        }

        static bool ShowAddOrdersScreen()
        {
            Console.Clear();
            Console.WriteLine("SECOND BAKERY: Add Order");
            Console.WriteLine("------------------");
            Console.WriteLine("1. Baguettes");
            Console.WriteLine("2. White Bread");
            Console.WriteLine("3. Hamburger Bread");
            Console.WriteLine("4. Back to 2nd Bakery");
            Console.Write("\r\nSelect an option: ");

            switch (Utility.ValidateNumericInput())
            {
                case 1:
                    ShowAddBaguettesScreen();
                    return true;
                case 2:
                    ShowAddWhiteBreadScreen();
                    return true;
                case 3:
                    ShowAddHamburguerBreadScreen();
                    return true;
                case 4:
                    ShowOfficeMenu();
                    return true;
                default:
                    return true;
            }
        }

        static bool ShowAddBaguettesScreen()
        {
            Console.Clear();
            Console.WriteLine("ADD ORDER: Baguette");
            Console.WriteLine("------------------");
            Console.WriteLine("\r\nEnter quantity to prepare: ");

            totalBaguetteQuantity = (from baguettes in baguetteList select baguettes.Quantity).Sum();
            int baguetteQtyInput = Utility.ValidateNumericInput();

            // Check if input doesnt exceed maximum
            if (baguetteQtyInput > maxOrders2ndOffice)
            {
                Console.WriteLine("Cannot order more than " + maxOrders2ndOffice + " units");
                Thread.Sleep(3000);
                ShowAddBaguettesScreen();
            }

            // Add order if total units doesnt exceed maximum
            if ((totalBaguetteQuantity + totalWhiteBreadQuantity + totalHamburguerBreadQuantity + baguetteQtyInput) <= maxOrders2ndOffice)
            {
                Baguette b = new Baguette(baguetteQtyInput);
                baguetteList.Add(b);
                totalBaguetteQuantity = (from baguettes in baguetteList select baguettes.Quantity).Sum();
                b.PrintBreadTypeDetails(totalBaguetteQuantity);
            }
            else
            {
                //Show how many can be ordered
                Console.WriteLine("Only " + (maxOrders2ndOffice - (totalBaguetteQuantity + totalWhiteBreadQuantity + totalHamburguerBreadQuantity)) + " of " + maxOrders2ndOffice + " units available to order.");
                Thread.Sleep(3000);
                ShowAddOrdersScreen();
            }

            //Show selection menu
            Console.WriteLine("\r\n1. Add More Orders \r\n2. Prepare All Orders \r\nSelect an option: ");

            switch (Utility.ValidateNumericInput())
            {
                case 1:
                    ShowAddOrdersScreen();
                    return true;
                case 2:
                    ShowOrderDetails();
                    return true;
                default:
                    return true;
            }
        }

        static bool ShowAddWhiteBreadScreen()
        {
            Console.Clear();
            Console.WriteLine("ADD ORDER: White Bread");
            Console.WriteLine("------------------");
            Console.WriteLine("\r\nEnter quantity to prepare: ");

            totalWhiteBreadQuantity = (from whiteBread in whiteBreadList select whiteBread.Quantity).Sum();
            int whiteBreadQtyInput = Utility.ValidateNumericInput();

            // Check if input doesnt exceed maximum
            if (whiteBreadQtyInput > maxOrders2ndOffice)
            {
                Console.WriteLine("Cannot order more than " + maxOrders2ndOffice + " units");
                Thread.Sleep(3000);
                ShowAddOrdersScreen();
            }

            // Add order if total units doesnt exceed maximum
            if ((totalBaguetteQuantity + totalWhiteBreadQuantity + totalHamburguerBreadQuantity + whiteBreadQtyInput) <= maxOrders2ndOffice)
            {
                WhiteBread wb = new WhiteBread(whiteBreadQtyInput);
                whiteBreadList.Add(wb);
                totalWhiteBreadQuantity = (from whiteBread in whiteBreadList select whiteBread.Quantity).Sum();
                wb.PrintBreadTypeDetails(totalWhiteBreadQuantity);
            }
            else
            {
                //Show how many can be ordered
                Console.WriteLine("Only " + (maxOrders2ndOffice - (totalBaguetteQuantity + totalWhiteBreadQuantity + totalHamburguerBreadQuantity)) + " of " + maxOrders2ndOffice + " units available to order.");
                Thread.Sleep(3000);
                ShowAddOrdersScreen();
            }

            // Selection menu
            Console.WriteLine("\r\n1. Add More Orders \r\n2. Prepare All Orders \r\nSelect an option: ");

            switch (Utility.ValidateNumericInput())
            {
                case 1:
                    ShowAddOrdersScreen();
                    return true;
                case 2:
                    ShowOrderDetails();
                    return true;
                default:
                    return true;
            }
        }

        static bool ShowAddHamburguerBreadScreen()
        {
            Console.Clear();
            Console.WriteLine("ADD ORDER: Hamburguer Bread");
            Console.WriteLine("------------------");
            Console.WriteLine("\r\nEnter quantity to prepare: ");

            totalHamburguerBreadQuantity = (from HamburguerBread in hamburguerBreadList select HamburguerBread.Quantity).Sum();
            int hamburguerBreadQtyInput = Utility.ValidateNumericInput();

            // Check if input doesnt exceed maximum
            if (hamburguerBreadQtyInput > maxOrders2ndOffice)
            {
                Console.WriteLine("Cannot order more than " + maxOrders2ndOffice + " units");
                Thread.Sleep(3000);
                ShowAddOrdersScreen();
            }

            // Add order if total units doesnt exceed maximum
            if ((totalBaguetteQuantity + totalWhiteBreadQuantity + totalHamburguerBreadQuantity + hamburguerBreadQtyInput) <= maxOrders2ndOffice)
            {
                HamburguerBread hb = new HamburguerBread(hamburguerBreadQtyInput);
                hamburguerBreadList.Add(hb);
                totalHamburguerBreadQuantity = (from HamburguerBread in hamburguerBreadList select HamburguerBread.Quantity).Sum();
                hb.PrintBreadTypeDetails(totalHamburguerBreadQuantity);
            }
            else
            {
                //Show how many can be ordered
                Console.WriteLine("Only " + (maxOrders2ndOffice - (totalBaguetteQuantity + totalWhiteBreadQuantity + totalHamburguerBreadQuantity)) + " of " + maxOrders2ndOffice + " units available to order.");
                Thread.Sleep(3000);
                ShowAddOrdersScreen();
            }

            //Selection menu
            Console.WriteLine("\r\n1. Add More Orders \r\n2. Prepare All Orders \r\nSelect an option: ");

            switch (Utility.ValidateNumericInput())
            {
                case 1:
                    ShowAddOrdersScreen();
                    return true;
                case 2:
                    ShowOrderDetails();
                    return true;
                default:
                    return true;
            }
        }

        static bool ShowOrderDetails()
        {
            // Get bread quantities
            totalBaguetteQuantity = (from baguettes in baguetteList select baguettes.Quantity).Sum();
            totalWhiteBreadQuantity = (from whiteBread in whiteBreadList select whiteBread.Quantity).Sum();
            totalHamburguerBreadQuantity = (from HamburguerBread in hamburguerBreadList select HamburguerBread.Quantity).Sum();
            // Show message if there are no orders to prepare
            if (totalBaguetteQuantity == 0 && totalWhiteBreadQuantity == 0 && totalHamburguerBreadQuantity == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("(!) No orders to prepare");
                Console.ForegroundColor = ConsoleColor.Gray;
                Thread.Sleep(3000);
                ShowOfficeMenu();
            }

            Console.Clear();
            Console.WriteLine("SECOND BAKERY: Order Details");
            Console.WriteLine("------------------");
            Console.WriteLine($"Baguette: {totalBaguetteQuantity}u (${Baguette._costPerUnit} each)");
            Console.WriteLine($"White bread: {totalWhiteBreadQuantity}u (${WhiteBread._costPerUnit} each)");
            Console.WriteLine($"Hamburger bun: {totalHamburguerBreadQuantity}u (${HamburguerBread._costPerUnit} each)");
            //Calculate grand totad
            Console.WriteLine($"Total cost : ${(totalBaguetteQuantity*Baguette._costPerUnit) + (totalWhiteBreadQuantity*WhiteBread._costPerUnit) + (totalHamburguerBreadQuantity*HamburguerBread._costPerUnit)}");
            // Show selection menu
            Console.WriteLine("\r\n1. Confirm \r\n2. Cancel \r\nSelect an option: ");

            switch (Utility.ValidateNumericInput())
            {
                case 1:
                    ShowPrepareOrdersScreen();
                    return true;
                case 2:
                    //Empty lists if cancelled
                    baguetteList.Clear();
                    whiteBreadList.Clear();
                    hamburguerBreadList.Clear();
                    ShowPrepareOrdersScreen();
                    return true;
                default:
                    return true;
            }
        }

        static void ShowPrepareOrdersScreen()
        {
            Console.Clear();
            Console.WriteLine("SECOND BAKERY: Preparing Orders");
            Console.WriteLine("------------------");
            //Get quantities
            totalBaguetteQuantity = (from baguettes in baguetteList select baguettes.Quantity).Sum();
            totalWhiteBreadQuantity = (from whiteBread in whiteBreadList select whiteBread.Quantity).Sum();
            totalHamburguerBreadQuantity = (from HamburguerBread in hamburguerBreadList select HamburguerBread.Quantity).Sum();

            if (totalBaguetteQuantity == 0 && totalWhiteBreadQuantity == 0 && totalHamburguerBreadQuantity == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("(!) No orders to prepare");
                Console.ForegroundColor = ConsoleColor.Gray;
                Thread.Sleep(3000);
                ShowOfficeMenu();
            }

            if (totalBaguetteQuantity > 0)
            {
                Baguette baguetteBread = new Baguette(totalBaguetteQuantity);
                baguetteBread.PrintRecipe();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\r\nBaguette preparation is complete");
                Console.ForegroundColor = ConsoleColor.Gray;
                baguetteList.Clear();
                Console.Write("\r\nPress Enter to continue...\r\n");
                Console.ReadLine();
            }

            if (totalWhiteBreadQuantity > 0)
            {
                WhiteBread whiteBreadBread = new WhiteBread(totalWhiteBreadQuantity);
                whiteBreadBread.PrintRecipe();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\r\nWhite Bread preparation is complete");
                Console.ForegroundColor = ConsoleColor.Gray;
                whiteBreadList.Clear();
                Console.Write("\r\nPress Enter to continue...\r\n");
                Console.ReadLine();
            }

            if (totalHamburguerBreadQuantity > 0)
            {
                HamburguerBread milkBreadBread = new HamburguerBread(totalHamburguerBreadQuantity);
                milkBreadBread.PrintRecipe();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\r\nHamburguer Bun preparation is complete");
                Console.ForegroundColor = ConsoleColor.Gray;
                hamburguerBreadList.Clear();
                Console.Write("\r\nPress Enter to continue...\r\n");
                Console.ReadLine();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\r\nALL ORDERS COMPLETED");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("\r\nPress Enter to continue...");
                Console.ReadLine();
            }
            MainMenu.ShowMainMenu();
        }
    }
}

