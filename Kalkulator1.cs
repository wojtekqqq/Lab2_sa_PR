using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Kalkulator1 : ICalculator
    {
        public int Id => 1;
        public string Name => "Metoda Kwadratów";

        public decimal GetIntegralValue(IFunction function, decimal rangeFrom, decimal rangeTo)
        {
            decimal powierzchnia = 0;
            decimal krok = ((decimal)rangeTo - (decimal)rangeFrom) / (decimal)99;
            decimal x = rangeFrom + krok / 2;

            for (int i = 1; i <= 99; i++)
            {
                powierzchnia += function.GetY(x) * krok;
                x += krok;
            }

            Console.WriteLine("Przybliżona wartość całki przy wariancie środkowych kwadratów :" + powierzchnia);

            return powierzchnia;
        }
    }
}
