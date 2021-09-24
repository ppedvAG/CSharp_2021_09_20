using System;
using System.Threading;

namespace M013_02_ThreadMitParameterStarten
{
    class Program
    {
        static void Main(string[] args)
        {
            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(MacheEtwasInEinemThread);

            Thread thread = new Thread(parameterizedThreadStart);

            thread.Start(100);
            thread.Join();

            for (int i = 0; i < 100; i++)
                Console.WriteLine("*");


            Console.ReadLine();
        }



        private static void MacheEtwasInEinemThread(object obj)
        {
            for (int i = 0; i < (int)obj; i++)
                Console.WriteLine($"{i} #");
        }
    }
}
