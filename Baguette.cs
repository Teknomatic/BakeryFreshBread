using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryFreshBread
{
    class Baguette : BreadBase
    {
        public static double _costPerUnit = 2.0f;
        public Baguette(int quantity)
        {
            this._quantity = quantity;
            //_costPerUnit = 2.0f;
            _flourGrams = 280;
            _waterCC = 210;
            _saltGrams = 10;
            _yeastGrams = 5;
            _bakingTime = 30;
            _restingTime = 30;
            _fermentTime = 1440;
            _bakingTemperature = 270;
        }
        public int Quantity
        {
            get { return _quantity; }
        }

        public override void PrintBreadTypeDetails(int totatUnits)
        {
            Console.WriteLine("------------------");
            Console.WriteLine($"Total qty: {totatUnits}");
            Console.WriteLine($"Total cost: ${_costPerUnit * _quantity}");
        }
        public override void PrintRecipe()
        {
            Console.WriteLine("BAGUETTE RECIPE:");
            Console.WriteLine($"\r\nINGREDIENTS ({_quantity}u): \r\nFlour {_flourGrams * _quantity}g. \r\nWater {_waterCC * _quantity}cc \r\nSalt {_saltGrams * _quantity}g. \r\nYeast {_yeastGrams * _quantity}g.");
            Console.WriteLine("\r\nPREPARATION:");
            Console.WriteLine($"1. Mixing the {_flourGrams * _quantity}g of flour, {_waterCC * _quantity}cc of water, {_yeastGrams * _quantity}g of yeast and {_saltGrams * _quantity}g of salt,");
            Console.WriteLine("2. Cutting the dough");
            Console.WriteLine($"3. Let the dough rest for {_restingTime} minutes");
            Utility.WaitTimer(_restingTime);
            if (_quantity > 1) Console.WriteLine("4. Cut dough");
            Console.WriteLine($"5. Letting dought fermet for {_fermentTime / 60} hours");
            Utility.WaitTimer(_fermentTime);
            Console.WriteLine($"6. Baking the dough at {_bakingTemperature} for {_bakingTime}");
            Utility.WaitTimer(_bakingTime);
        }
    }
}
