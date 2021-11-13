using System;
using System.Collections.Generic;

namespace Lab2_sa
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var f1 = new Funkcja1();
            var f2 = new Funkcja2();
            var f3 = new Funkcja3();
            var functions = new List<IFunction>
            {
                f1,
                f2,
                f3
            };
            var bg1 = new Bg();
            var bgw1 = new Bgw();
            var bgw2 = new Bgw();
            var bgw3 = new Bgw();

            var kal1 = new Kalkulator1();

            var p1 = new Przedzial1();
            var p2 = new Przedzial2();
            var p3 = new Przedzial3();
            var przedzialy = new List<IPrzedzialy>
            {
                p1,
                p2,
                p3
            };

            Console.WriteLine("*********************** " +
                              "Obliczanie przybliżonej wartości całki dla wybranej funkji i zakresu danych ******************");

            foreach (var f in functions) Console.WriteLine("Nr funkcji: " + f.Id + " " + f.Name);
            foreach (var p in przedzialy) Console.WriteLine(p.Name + " " + p.Id);
            Console.WriteLine("");
            Console.WriteLine("Podaj nr funkcji");
            var idFunkcji = Convert.ToInt32(Console.ReadLine());
            var wybranyIdFunkcji = functions.Find(item => item.Id == idFunkcji);
            while (wybranyIdFunkcji == null)
            {
                Console.WriteLine("Nr poza zakresem podaj jeszcze raz");
                idFunkcji = Convert.ToInt32(Console.ReadLine());
                wybranyIdFunkcji = functions.Find(item => item.Id == idFunkcji);
            }

            Console.WriteLine("############## Podano do obliczeń ####################");
            Console.WriteLine("Wybrana funkcja to: " + wybranyIdFunkcji.Name);
            Console.WriteLine("");

            bg1.Run(wybranyIdFunkcji, przedzialy);

            //wywołanie 
/*            bgw1.Run(wybranyIdFunkcji, Przedzialy[0].rangeFrom(), Przedzialy[0].rangeTo(), Przedzialy[0].Name);
            bgw2.Run(wybranyIdFunkcji, Przedzialy[1].rangeFrom(), Przedzialy[1].rangeTo(), Przedzialy[1].Name);
            bgw3.Run(wybranyIdFunkcji, Przedzialy[2].rangeFrom(), Przedzialy[2].rangeTo(), Przedzialy[2].Name);*/
        }
    }
}