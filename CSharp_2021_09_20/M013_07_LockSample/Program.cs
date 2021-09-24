using System;
using System.Collections.Generic;
using System.Threading;

namespace M013_07_LockSample
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Thread> threadList = new List<Thread>();

            //Thread newThread = null;

            for (int i = 0; i < 100; i++)
            {
                threadList.Add(new Thread(MachEinKontoUpdate));
            }

            for (int i = 0; i < 100; i++)
            {
                threadList[i].Start();
            }


            Console.WriteLine("fertig");
            Console.ReadKey();
        }

        private static void MachEinKontoUpdate(object state) //Diese Methode läuft jeweils in einem speraten Thread
        {
            Random r = new Random();

            for (int i = 0; i < 50; i++)
            {
                int auswahl = r.Next(0, 10);

                if (auswahl % 2 == 0)
                {
                    Konto.Einzahlen(r.Next(0, 1000));
                }
                else
                    Konto.Abheben(r.Next(0, 1000));
            }
        }
    }
}
