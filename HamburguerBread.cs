using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryFreshBread
{
    class HamburguerBread : BreadBase
    {
        public static double _costPerUnit = 1.0f;
        readonly int sugarGrams;
        readonly int eggGrams;
        readonly int milkCC;
        readonly int butterGrams;
        readonly int sweetpotatoGrams;
        readonly int sesameSeedGrams;
        readonly int gildingGrams;

        public HamburguerBread(int quantity)
        {
            this._quantity = quantity;
            _flourGrams = 55;
            _waterCC = 25;
            _saltGrams = 1;
            _yeastGrams = 3;
            this.sugarGrams = 6;
            this.eggGrams = 10;
            this.milkCC = 20;
            this.butterGrams = 10;
            this.sweetpotatoGrams = 2;
            this.sesameSeedGrams = 10;
            this.gildingGrams = 5;
            _bakingTime = 15;
            _restingTime = 30;
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
            Console.WriteLine("HAMBURGUER RECIPE:");
            Console.WriteLine($"\r\nINGREDIENTS ({_quantity}u): \r\nFlour {_flourGrams * _quantity}g. \r\nWater {_waterCC * _quantity}cc \r\nSalt {_saltGrams * _quantity}g. \r\nYeast {_yeastGrams * _quantity}g. \r\nSugar {sugarGrams * _quantity}g. \r\nEggs {eggGrams * _quantity}g \r\nMilk {milkCC * _quantity}g. \r\nButter {butterGrams * _quantity}g \r\nSweet potato {sweetpotatoGrams * _quantity}g \r\nSesame seeds {sesameSeedGrams * _quantity}g \r\nGilding{gildingGrams * _quantity}");
            Console.WriteLine("\r\nPREPARATION:");
            Console.WriteLine($"1. Mixing the {_flourGrams * _quantity}g of flour, {_waterCC * _quantity}cc of water, {_yeastGrams * _quantity}g of yeast and {_saltGrams * _quantity}g of salt, {sugarGrams * _quantity}g of sugar, {eggGrams * _quantity} egg units, {butterGrams * _quantity}cc of butter, {milkCC * _quantity}cc of milk, {sweetpotatoGrams * _quantity}g of sweet potato, {sesameSeedGrams * _quantity}g of sesame seeds");
            Console.WriteLine("2. Cutting the dough");
            Console.WriteLine($"3. Let the dough rest for {_restingTime} minutes");
            Utility.WaitTimer(_restingTime);
            Console.WriteLine("4. Shaping dough into baguettes");
            Console.WriteLine($"5. Letting dought fermet for {_fermentTime / 60} hours");
            Utility.WaitTimer(_fermentTime);
            Console.WriteLine("6. Put the sesame seeds and the gilding on top of dough");
            Console.WriteLine($"7. Baking the dough at {_bakingTemperature} for {_bakingTime}");
            Utility.WaitTimer(_bakingTime);
        }
    }
}
