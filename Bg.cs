using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab1
{
    class Bg
    {
        public void Run(IFunction function, decimal rangeFrom, decimal rangeTo, string name)
        {

            var backgroundWorker1 = new BackgroundWorker();
            List<object> arguments1 = new List<object>();
            arguments1.Add(function);
            arguments1.Add(rangeFrom);
            arguments1.Add(rangeTo);
            arguments1.Add(name);


            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += DoWork;
            backgroundWorker1.ProgressChanged += ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += WorkCompleted;
            backgroundWorker1.RunWorkerAsync(arguments1);
            /*                backgroundWorker.RunWorkerAsync();*/
            Console.WriteLine("Naciśnij c aby zakończyć");
            while (backgroundWorker1.IsBusy)
            {
                if (Console.ReadKey(true).KeyChar == 'c')
                {
                    backgroundWorker1.CancelAsync();

                }
            }
        }
       private void DoWork(object sender, DoWorkEventArgs e)
        {
            List<object> argslist = e.Argument as List<object>;

            IFunction funkcja = (IFunction)argslist[0];
            decimal rangeTo = (decimal)argslist[2];
            decimal rangeFrom = (decimal)argslist[1];
            string name = (string)argslist[3];
            Console.WriteLine("############## T ####################");


            var worker = sender as BackgroundWorker;

                decimal powierzchnia = 0;

                decimal krok = ((decimal)rangeTo - (decimal)rangeFrom) / 100;
                decimal x = (decimal)rangeFrom;


            for (int i = 1; i < 100; i++)
            {
                if (!worker.CancellationPending)
                {
                    powierzchnia += funkcja.GetY((decimal)rangeFrom + i * krok);
                    /*Thread.Sleep(100);*/
                    if (i%10 == 0)
                    {
                        worker.ReportProgress(i * 1);
                    }
                    
                }
                else
                {
                    worker.CancelAsync();
                }
            }
                powierzchnia = (powierzchnia + (funkcja.GetY(rangeFrom) + funkcja.GetY(rangeTo)) / 2) * krok;

/*            Console.WriteLine("Przybliżona wartość całki metodą trapezów :" + powierzchnia);*/
            e.Result = "Przybliżona wartość całki metodą trapezów dla przedziału: " + name+ " wynosi " + powierzchnia;

            /*                    kal1.GetIntegralValue(wybranyIdFunkcji, P.rangeFrom(), P.rangeTo());*/
            /*                       kal1.GetIntegralValue(wybranyIdFunkcji, P.rangeFrom(), P.rangeTo());*/
            /*                    Thread.Sleep(1000);
                                    worker.ReportProgress(idFunkcji * 1);*/
            /*            }
                        else
                        {
                            worker.CancelAsync();
                        }*/
            /*                }*/
            /*            e.Result = kal1;*/
        }
        void ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Console.WriteLine($"Postęp {e.ProgressPercentage}%");
        }
        void WorkCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine($"Zadanie zakończone {e.Result}");
            Console.WriteLine("");
        }
    }
}
