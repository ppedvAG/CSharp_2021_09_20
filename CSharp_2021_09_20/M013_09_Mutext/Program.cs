using System;
using System.Threading;

namespace M013_09_Mutext
{
    class Program
    {
        private static Mutex mutex = null;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private static void DoSomething()
        {
            mutex = new Mutex(false, "MyMutex");
            bool lockToken = false;

            try
            {
                //Erster Thread belegt das Tocken und weitere Thread muss hier warten. 
                lockToken = mutex.WaitOne();
                //Berechne etwas wichtiges
            }
            finally
            {
                if (lockToken)
                {
                    mutex.ReleaseMutex(); //Code-Bereich wird für den nächsten Thread freigegeben. 
                }
            }
        }
    }
}
