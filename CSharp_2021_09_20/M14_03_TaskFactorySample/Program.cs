using System;
using System.Threading.Tasks;

namespace M14_03_TaskFactorySample
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = Task.Factory.StartNew(MachEtwasInEinemThread);
            task.Wait();
            Console.WriteLine("Nächste Ausgabe\n");
            Task task2 = Task.Run(MachEtwasInEinemThread);//Intern wird Task.Factory.StartNew aufgerufen -> Task.Run dient lediglich als verkürzte Schreibweise.
            task2.Wait();

            Console.WriteLine("Bin fertig");
            Console.ReadLine();
        }


        private static void MachEtwasInEinemThread()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write("#");
            }
            Console.WriteLine(string.Empty);
        }
    }
}
