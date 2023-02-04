using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryFreshBread
{
    abstract class BreadBase
    {
        public int _quantity;
        public int _flourGrams;
        public int _waterCC;
        public int _saltGrams;
        public int _yeastGrams;
        public int _bakingTime; // minutes
        public int _restingTime; // minutes
        public int _fermentTime; // minutes
        public double _bakingTemperature;

        public abstract void PrintBreadTypeDetails(int totatUnits);
        public abstract void PrintRecipe();
    }
}
