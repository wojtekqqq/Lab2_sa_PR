using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Funkcja1 F1 = new Funkcja1();
            Funkcja2 F2 = new Funkcja2();
            Funkcja3 F3 = new Funkcja3();
            Funkcja4 F4 = new Funkcja4(); //Dodano z zadania 2
            List<IFunction> Functions = new List<IFunction>();
            Functions.Add(F1);
            Functions.Add(F2);
            Functions.Add(F3);
            Functions.Add(F4); //Dodano z zadania 2

            Kalkulator1 kal1 = new Kalkulator1();
            Kalkulator2 kal2 = new Kalkulator2();
            List<ICalculator> Kalkulatory = new List<ICalculator>();
            Kalkulatory.Add(kal1);
            Kalkulatory.Add(kal2);

            Przedzial1 P1 = new Przedzial1();
            Przedzial2 P2 = new Przedzial2();
            Przedzial3 P3 = new Przedzial3();
            List<IPrzedzialy> Przedzialy = new List<IPrzedzialy>();
            Przedzialy.Add(P1);
            Przedzialy.Add(P2);
            Przedzialy.Add(P3);

            Console.WriteLine("*********************** " +
                "Obliczanie przybliżonej wartości całki dla wybranej funkji i zakresu danych ******************");

            foreach (var F in Functions)
            {
                Console.WriteLine("Nr funkcji: " + F.Id + " " + F.Name);
            }
            foreach (var P in Przedzialy)
            {
                Console.WriteLine(P.Name + " " + P.Id);
            }
            Console.WriteLine("");
            Console.WriteLine("Podaj nr funkcji");
            int idFunkcji = Convert.ToInt32(Console.ReadLine());
            var wybranyIdFunkcji = Functions.Find(item => item.Id == idFunkcji);
            while (wybranyIdFunkcji == null)
            {
                Console.WriteLine("Nr poza zakresem podaj jeszcze raz");
                idFunkcji = Convert.ToInt32(Console.ReadLine());
                wybranyIdFunkcji = Functions.Find(item => item.Id == idFunkcji);
            }
            Console.WriteLine("Podaj nr przedziału");
            int idPrzedzialu = Convert.ToInt32(Console.ReadLine());
            var wybranyIdPrzedzialu = Przedzialy.Find(item => item.Id == idPrzedzialu);

            while (wybranyIdPrzedzialu == null)
            {
                Console.WriteLine("Nr poza zakresem podaj jeszcze raz");
                idPrzedzialu = Convert.ToInt32(Console.ReadLine());
                wybranyIdPrzedzialu = Przedzialy.Find(item => item.Id == idPrzedzialu);
            }
            Console.WriteLine("############## Podano do obliczeń ####################");
            Console.WriteLine("Wybrana funkcja to: " + wybranyIdFunkcji.Name);
            Console.WriteLine("Wybrany przedział to: " + wybranyIdPrzedzialu.Name);
            Console.WriteLine("");
            foreach (var K in Kalkulatory)
            {
                Console.WriteLine("Rodzaj kalkulatora: " + K.Name);

                K.GetIntegralValue(wybranyIdFunkcji, wybranyIdPrzedzialu.rangeFrom(), wybranyIdPrzedzialu.rangeTo());
                Console.WriteLine("");
            }
        }
    }
}
