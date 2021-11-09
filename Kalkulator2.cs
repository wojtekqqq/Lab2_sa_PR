using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Kalkulator2 : ICalculator
    {
        public int Id => 2;
        public string Name => "Metoda trapezow";

        public decimal GetIntegralValue(IFunction function, decimal rangeFrom, decimal rangeTo)
        {
            decimal powierzchnia = 0;

            decimal krok = ((decimal)rangeTo - (decimal)rangeFrom) / 99;
            decimal x = rangeFrom;


            for (int i = 1; i < 99; i++)
            {
                powierzchnia += function.GetY(rangeFrom + i * krok);
            }
            powierzchnia = (powierzchnia + (function.GetY(rangeFrom) + function.GetY(rangeTo)) / 2) * krok;
            Console.WriteLine("Przybliżona wartość całki metodą trapezów :" + powierzchnia);
            return powierzchnia;
        }
    }
}
