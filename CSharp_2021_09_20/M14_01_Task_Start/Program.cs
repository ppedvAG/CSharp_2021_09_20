using System;
using System.Threading.Tasks;

namespace M14_01_Task_Start
{
    class Program
    {
        static void Main(string[] args)
        {
            Task easyTask = new Task(MachEtwasInEinemThread); //Funktionszeiger der Methode übergeben 
            easyTask.Start();
            easyTask.Wait();

            

            for (int i = 0; i < 400; i++)
            {
                Console.Write("*");
            }

            Console.ReadKey();
        }


        private static void MachEtwasInEinemThread()
        {
            for (int i = 0; i < 400; i++)
            {
                Console.Write("#");
            }
        }
    }
}
