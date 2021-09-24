using System;

using System.Threading;

namespace M013_01_Thread_starten
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(MacheEtwasInEinemThread); //<- hier wird der Funktionszeiger von MacheEtwasInEinemThread übergeben

            thread.Start(); //Ab hier werden 2 Prozesse gleichzeitig abgehandelt (Main-Methode + MacheEtwasInEinemThread

            thread.Join(); //Wir warten, bis MacheEtwasInEinemThread

            for (int i = 0; i < 500; i++)
                Console.WriteLine("*");

            Console.ReadLine();

        }


        private static void MacheEtwasInEinemThread()
        {
            for (int i = 0; i < 500; i++)
                Console.WriteLine("#");
        }
    }
}
