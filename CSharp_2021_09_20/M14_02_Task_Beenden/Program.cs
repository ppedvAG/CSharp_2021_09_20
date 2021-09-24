using System;
using System.Threading;
using System.Threading.Tasks;

namespace M14_02_Task_Beenden
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource(); //Ab .NET 4.0 

            //Task task = Task.Factory.StartNew(MeineMethodeMitAbbrechen, cts); //Benötigt kein Start -> startet ab jetzt! 

            Task easyTask = new Task(MeineMethodeMitAbbrechen, cts); //cts ist ein Referenztyp -> wird können von aussen immer noch cts beeinflussen
            easyTask.Start();

            Thread.Sleep(5000);
            cts.Cancel(); //Nach 5 SEkunden, geben wir die Anweisung, dass Task Beendet wird

            //cts.CancelAfter(5000); -> Funktioniert nicht so ganz
        }


        private static void MeineMethodeMitAbbrechen(object param)
        {
            CancellationTokenSource source = (CancellationTokenSource)param;

            while (true)
            {
                Console.WriteLine("zzzzZZZzzzZZZzzzZZZzzzZZZZZ");
                Thread.Sleep(50);

                if (source.IsCancellationRequested)
                    break;
            }
        }
    }
}
