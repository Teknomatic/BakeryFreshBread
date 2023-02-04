using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryFreshBread
{
    class MilkBread : BreadBase
    {
        public static double _costPerUnit = 1.5f;
        readonly int _sugarGrams;
        readonly int _eggGrams;
        readonly int _milkCC;
        readonly int _butterGrams;
        readonly int _honeyGrams;
        readonly int _lemonZestGrams;
        readonly int _vanillaEssense;


        public MilkBread(int quantity)
        {
            this._quantity = quantity;
            _flourGrams = 55;
            _waterCC = 25;
            _saltGrams = 1;
            _yeastGrams = 3;
            this._sugarGrams = 6;
            this._eggGrams = 10;
            this._milkCC = 20;
            this._butterGrams = 10;
            this._honeyGrams = 2;
            this._lemonZestGrams = 1;
            this._vanillaEssense = 1;
            _bakingTime = 15;
            _restingTime = 10;
            _fermentTime = 120;
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
            Console.WriteLine("MILK BREAD RECIPE:");
            Console.WriteLine($"\r\nINGREDIENTS ({_quantity}u): \r\nFlour {_flourGrams * _quantity}g. \r\nWater {_waterCC * _quantity}cc \r\nSalt {_saltGrams * _quantity}g. \r\nYeast {_yeastGrams * _quantity}g. \r\nSugar {_sugarGrams * _quantity}g. \r\nEggs {_eggGrams * _quantity}g \r\nMilk {_milkCC * _quantity}g. \r\nButter {_butterGrams * _quantity}g \r\nLemon zest {_lemonZestGrams * _quantity}g \r\nVanilla essence{_vanillaEssense * _quantity}g");
            Console.WriteLine("\r\nPREPARATION:");
            Console.WriteLine($"1. Mixing the {_flourGrams * _quantity}g of flour, {_waterCC * _quantity}cc of water, {_yeastGrams * _quantity}g of yeast and {_saltGrams * _quantity}g of salt, {_sugarGrams * _quantity}g of sugar, {_eggGrams * _quantity}g of eggs, {_butterGrams * _quantity}cc of butter, {_milkCC * _quantity}cc of milk.{_honeyGrams * _quantity}g of honey, {_lemonZestGrams * _quantity}g of lemon zest, {_vanillaEssense * _quantity}cc of Vanilla essence.");
            Console.WriteLine("2. Cutting the dough");
            Console.WriteLine($"3. Let the dough rest for {_restingTime} minutes");
            Utility.WaitTimer(_restingTime);
            Console.WriteLine("4. Shaping dough into bread units");
            Console.WriteLine($"5. Letting dought fermet for {_fermentTime / 60} hours");
            Utility.WaitTimer(_fermentTime);
            Console.WriteLine($"6. Baking the dough at {_bakingTemperature} for {_bakingTime}");
            Utility.WaitTimer(_bakingTime);
        }
    }
}
