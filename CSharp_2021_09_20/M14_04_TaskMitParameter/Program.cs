using System;
using System.Threading.Tasks;

namespace M14_04_TaskMitParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Katze katze = new();

            Task<string> task1 = new Task<string>(() => MachEtwas(katze));
            task1.Start();
            task1.Wait();

            string result = task1.Result;

            //Beispiel mit mehrere Parameter
            Task<string> task2 = new Task<string>(() => MachEtwas(katze, DateTime.Now));
            task2.Start();
            task2.Wait();

            Console.WriteLine(task2.Result);


            //Via Fctory
            Task<string> task3 = Task.Factory.StartNew(MachEtwas, katze);
            task3.Wait();
            Console.WriteLine(task3.Result);


            // via Task.Run()
            Task<string> task4 = Task.Run<string>(() => MachEtwas(katze));
            task4.Wait();
            Console.WriteLine(task4.Result);
        }


        private static string MachEtwas(object input)
        {
            if (input is Katze myCat)
                return myCat.Name;

            throw new ArgumentException();
        }

        private static string MachEtwas(object input, DateTime dateTime)
        {
            Katze katze = (Katze)input;
            Console.WriteLine(katze.Name);
            
            //Console.WriteLine(((Katze)input).Name);
            Console.WriteLine(dateTime.ToShortDateString());

            return dateTime.ToShortDateString();
        }
    }

    public class Katze
    {
        public string Name { get; set; } = "Maya";
    }
}
