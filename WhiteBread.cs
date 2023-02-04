using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryFreshBread
{
    class WhiteBread : BreadBase
    {
        public static double _costPerUnit = 2.5;
        readonly int _sugarGrams;
        readonly int _milkCC;
        readonly int _butterGrams;

        public WhiteBread(int quantity)
        {
            this._quantity = quantity;
            _flourGrams = 1000;
            _waterCC = 280;
            _saltGrams = 20;
            _yeastGrams = 20;
            this._sugarGrams = 80;
            this._milkCC = 60;
            this._butterGrams = 100;
            _bakingTime = 30;
            _restingTime = 60;
            _fermentTime = 240;
            _bakingTemperature = 180;
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
            Console.WriteLine("WHITE BREAD RECIPE:");
            Console.WriteLine($"\r\nINGREDIENTS ({_quantity}u): \r\nFlour {_flourGrams * _quantity}g. \r\nWater {_waterCC * _quantity}cc \r\nSalt {_saltGrams * _quantity}g. \r\nYeast {_yeastGrams * _quantity}g. \r\nSugar {_sugarGrams * _quantity}g. \r\nMilk {_milkCC * _quantity}g. \r\nButter {_butterGrams * _quantity}g.");
            Console.WriteLine("\r\nPREPARATION:");
            Console.WriteLine($"Mixing the {_flourGrams * _quantity}g of flour, {_waterCC * _quantity}cc of water, {_yeastGrams * _quantity}g of yeast and {_saltGrams * _quantity}g of salt, {_sugarGrams * _quantity}g of sugar, {_butterGrams * _quantity}cc of butter, {_milkCC * _quantity}cc of milk.");
            if (_quantity > 1) Console.WriteLine("Cut the dough");
            Console.WriteLine($"Let the dough rest for {_restingTime} minutes");
            Utility.WaitTimer(_restingTime);
            Console.WriteLine("Shaping dough into bread units");
            Console.WriteLine($"Letting dought fermet for {_fermentTime / 60} hours");
            Utility.WaitTimer(_fermentTime);
            Console.WriteLine($"Baking the dough at {_bakingTemperature} for {_bakingTime}");
            Utility.WaitTimer(_bakingTime);
        }
    }
}
