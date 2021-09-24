using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace M014_08_TaskWhenAllSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            List<Task<int>> taskCollection = new List<Task<int>>();
            
            List<Task<string>> tasks2Collection = new List<Task<string>>();


            for (int ctr = 1; ctr <= 10; ctr++)
            {
                int baseValue = ctr;
                taskCollection.Add(Task.Factory.StartNew(b => (int)b * (int)b, baseValue));

                //tasks2Collection.Add(Task.Factory.StartNew(b => b.ToString(), baseValue));
            }

            //extrahieren aus der List<Task<int>> alle int - Ergebnisse in ein int-Array 
            int[] results = await Task.WhenAll(taskCollection);
            string[] stringResults = await Task.WhenAll(tasks2Collection);


            int sum = 0;
            for (int ctr = 0; ctr <= results.Length - 1; ctr++)
            {
                var result = results[ctr];
                Console.Write($"{result} {((ctr == results.Length - 1) ? "=" : "+")} ");
                sum += result;
            }

            Console.WriteLine(sum);
        }
    }
}
