using System;
using System.Threading;

namespace M013_06_ThreadPool
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(Methode1); //Methode wird hier schon ausgeführt -> es wird kein explizierter Start benötigt. 
            ThreadPool.QueueUserWorkItem(Methode2);
            ThreadPool.QueueUserWorkItem(Methode3);

            Console.ReadLine();
        }

        static void Methode1(object state) //ThreadPool möchte den Parameter object in Methode1 haben
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(25);
                Console.WriteLine("#");
            }
        }

        static void Methode2(object state)
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(25);
                Console.WriteLine("*");
            }
        }

        static void Methode3(object state)
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(25);
                Console.WriteLine("O");
            }
        }
    }
}
