using System;
using System.Threading;
using System.Threading.Tasks;

namespace M14_06_ContinueSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t1 = new Task(() =>
            {
                Console.WriteLine("Task 1 ist gestartet");
                Thread.Sleep(1000);

                throw new Exception(); //Ein Fehler wird simuliert. 
            });


            t1.Start();
            
            t1.ContinueWith(t1 => AllgemeinerFolgetask());
            t1.ContinueWith(t1 => FolgetaskBeiFehler(), TaskContinuationOptions.OnlyOnFaulted);
            t1.ContinueWith(t1 => FolgetaskBeiErfolg(), TaskContinuationOptions.OnlyOnRanToCompletion);

            Console.ReadLine();
        }
        

        private static void AllgemeinerFolgetask()
        {
            Console.WriteLine("Allgemeiner Folgetask");
        }

        private static void FolgetaskBeiFehler()
        {
            Console.WriteLine("Folgetask bei Fehler");
        }

        private static void FolgetaskBeiErfolg()
        {
            Console.WriteLine("Folgetask bei Erfolg");
        }
    }
}
