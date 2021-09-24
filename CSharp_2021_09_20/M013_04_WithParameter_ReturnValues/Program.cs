using System;
using System.Threading;

namespace M013_04_WithParameter_ReturnValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string retStr = string.Empty;
            string meinText = "hello world";

            Thread thread = new Thread(() => //<- Anonyme Methode
            {
                //Was hier passiert, ist schon ein anderen Thread - Context
                retStr = StringToUpper(meinText);

            });

            thread.Start();
            thread.Join();


            Console.WriteLine(retStr);
            Console.ReadLine();
        }

        public static string StringToUpper(string param1)
        {
            return param1.ToUpper(); //Alles wird in Großbuchstaben zurückgegeben
        }
    }
}
