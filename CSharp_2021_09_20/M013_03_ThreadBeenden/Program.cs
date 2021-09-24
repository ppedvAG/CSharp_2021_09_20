using System;
using System.Threading;

namespace M013_03_ThreadBeenden
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(MachEtwas);
            thread.Start(); //Thread würde ~10 Sek. arbeiten

            //Programm läuft hierr weiter, solange kein thread.Join() verwendet 


            //Warten hier 3 Sek
            Thread.Sleep(3000);

            //thread.Abort();  //Abort ist Obselete und kann nicht mehr verwendet werden. 
            thread.Interrupt();

            Console.ReadLine();
        }

        private static void MachEtwas()
        {
            try
            {
                //50 x 200 Milisekunden -> 10 Sek,.
                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine("zzzZZZzzzzZZZzzzz");
                    Thread.Sleep(200);
                }
            }
            catch
            {

            }
        }
    }
}
