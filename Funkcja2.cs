using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Funkcja2 : IFunction
    {
        public int Id => 2;

        public string Name => "y=2x*x";

        public decimal GetY(decimal x)
        {
            return 2 * x * x;
        }
    }
}
