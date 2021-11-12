using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Xml.Linq;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Funkcja1 F1 = new Funkcja1();
            Funkcja2 F2 = new Funkcja2();
            Funkcja3 F3 = new Funkcja3();
            List<IFunction> Functions = new List<IFunction>();
            Functions.Add(F1);
            Functions.Add(F2);
            Functions.Add(F3);
            Bg bg1 = new Bg();
            Bg bg2 = new Bg();
           



            Kalkulator1 kal1 = new Kalkulator1();

/*            List<ICalculator> Kalkulatory = new List<ICalculator>();
            Kalkulatory.Add(kal1);*/

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
/*            Console.WriteLine("Podaj nr przedziału");
            int idPrzedzialu = Convert.ToInt32(Console.ReadLine());
            var wybranyIdPrzedzialu = Przedzialy.Find(item => item.Id == idPrzedzialu);

            while (wybranyIdPrzedzialu == null)
            {
                Console.WriteLine("Nr poza zakresem podaj jeszcze raz");
                idPrzedzialu = Convert.ToInt32(Console.ReadLine());
                wybranyIdPrzedzialu = Przedzialy.Find(item => item.Id == idPrzedzialu);
            }*/
            Console.WriteLine("############## Podano do obliczeń ####################");
            Console.WriteLine("Wybrana funkcja to: " + wybranyIdFunkcji.Name);     
            Console.WriteLine("");

            bg1.Run(wybranyIdFunkcji, Przedzialy[0].rangeFrom(), Przedzialy[0].rangeTo(), Przedzialy[0].Name);
            bg2.Run(wybranyIdFunkcji, Przedzialy[1].rangeFrom(), Przedzialy[1].rangeTo(), Przedzialy[1].Name);




            /*            foreach (var K in Kalkulatory)
                        {
                            Console.WriteLine("Rodzaj kalkulatora: " + K.Name);

                            K.GetIntegralValue(wybranyIdFunkcji, wybranyIdPrzedzialu.rangeFrom(), wybranyIdPrzedzialu.rangeTo());
                            Console.WriteLine("");
                        }*/






            /*            Run(wybranyIdFunkcji, Przedzialy[0].rangeFrom(), Przedzialy[0].rangeTo());
                        Run(wybranyIdFunkcji, Przedzialy[1].rangeFrom(), Przedzialy[1].rangeTo());
                        Run(wybranyIdFunkcji, Przedzialy[2].rangeFrom(), Przedzialy[2].rangeTo());

                        void Run(IFunction function, decimal rangeFrom, decimal rangeTo)*/
            /*            Run(wybranyIdFunkcji);*/

            /*void Run(IFunction function)
            {
                
                var backgroundWorker1 = new BackgroundWorker();
                var backgroundWorker2 = new BackgroundWorker();

                IFunction funkcja = wybranyIdFunkcji;
                *//*                decimal p1 = rangeFrom;
                                decimal p2 = rangeTo;*//*
                decimal p1 = Przedzialy[0].rangeFrom();
                decimal p2 = Przedzialy[0].rangeTo();
                List<object> arguments1 = new List<object>();
                arguments1.Add(function);
                arguments1.Add(p1);
                arguments1.Add(p2);
                decimal p3 = Przedzialy[1].rangeFrom();
                decimal p4 = Przedzialy[1].rangeTo();
                List<object> arguments2 = new List<object>();
                arguments2.Add(function);
                arguments2.Add(p3);
                arguments2.Add(p4);

                backgroundWorker1.WorkerReportsProgress = true;
                backgroundWorker1.WorkerSupportsCancellation = true;
                backgroundWorker1.DoWork += DoWork;
                backgroundWorker1.ProgressChanged += ProgressChanged;
*//*                backgroundWorker1.RunWorkerCompleted += WorkCompleted;*//*
                backgroundWorker1.RunWorkerAsync(arguments1);
                *//*                backgroundWorker.RunWorkerAsync();*//*
                Console.WriteLine("Naciśnij c aby zakończyć");
                while (backgroundWorker1.IsBusy)
                {
                    if (Console.ReadKey(true).KeyChar == 'c')
                    {
                        backgroundWorker1.CancelAsync();

                    }
                }

                backgroundWorker2.WorkerReportsProgress = true;
                backgroundWorker2.WorkerSupportsCancellation = true;
                backgroundWorker2.DoWork += DoWork;
                backgroundWorker2.ProgressChanged += ProgressChanged;
*//*                backgroundWorker2.RunWorkerCompleted += WorkCompleted;*//*
                backgroundWorker2.RunWorkerAsync(arguments2);
                *//*                backgroundWorker.RunWorkerAsync();*//*
                Console.WriteLine("Naciśnij c aby zakończyć");
                while (backgroundWorker2.IsBusy)
                {
                    if (Console.ReadKey(true).KeyChar == 'c')
                    {
                        backgroundWorker2.CancelAsync();

                    }
                }
            }*/





            /*            void DoWork(object sender, DoWorkEventArgs e)
                        {
                            List<object> argslist = e.Argument as List<object>;

                            IFunction funkcja = (IFunction)argslist[0];
                            decimal rangeTo = (decimal)argslist[1];
                            decimal rangeFrom = (decimal)argslist[2];
                            Console.WriteLine("############## T ####################");


                            var worker = sender as BackgroundWorker;

            *//*                foreach (var P in Przedzialy)
                            {*//*
                                if (!worker.CancellationPending)
                                {
                                decimal powierzchnia = 0;

                                decimal krok = ((decimal)rangeTo - (decimal)rangeFrom) / 100;
                                decimal x = (decimal)rangeFrom;


                                for (int i = 1; i < 100; i++)
                                {
                                    powierzchnia += funkcja.GetY((decimal)rangeFrom + i * krok);
                                    Thread.Sleep(10);
                                    worker.ReportProgress(i * 1);
                                }

                                powierzchnia = (powierzchnia + (funkcja.GetY(rangeFrom) + funkcja.GetY(rangeTo)) / 2) * krok;
                                Console.WriteLine("Przybliżona wartość całki metodą trapezów :" + powierzchnia);

            *//*                    kal1.GetIntegralValue(wybranyIdFunkcji, P.rangeFrom(), P.rangeTo());*/
            /*                       kal1.GetIntegralValue(wybranyIdFunkcji, P.rangeFrom(), P.rangeTo());*/
            /*                    Thread.Sleep(1000);
                                    worker.ReportProgress(idFunkcji * 1);*//*
                                }
                            else
                            {
                                worker.CancelAsync();
                            }
                            *//*                }*//*
                            e.Result = kal1;
                        }
                        void ProgressChanged(object sender, ProgressChangedEventArgs e)
                        {
                            Console.WriteLine($"Progress {e.ProgressPercentage}%");
                        }
                        void WorkCompleted(object sender, RunWorkerCompletedEventArgs e)
                        {
                            Console.WriteLine($"Work completed {e.Result}%");
                        }*/


        }
    }
}
