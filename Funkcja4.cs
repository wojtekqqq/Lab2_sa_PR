using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Zadanie 2. Trzeba dodać tutaj i w głównym programie na liście;*/
namespace Lab1
{
    class Funkcja4 : IFunction
    {
        public int Id => 4;

        public string Name => "y=3*x*x+2*x+3";

        public decimal GetY(decimal x)
        {
            return 3 * x * x + 2 * x + 3;
        }
    }
}
