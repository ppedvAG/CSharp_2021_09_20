using System;
using System.Threading.Tasks;

namespace M14_07_ContinueSampleWithParams
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<string> task = Task.Run(DayTime);
            task.ContinueWith(task => ShowDayTime(task.Result), TaskContinuationOptions.OnlyOnRanToCompletion);
            Console.ReadLine();
        }

        public static string DayTime()
        {
            DateTime date = DateTime.Now;

            return date.Hour > 17
                ? "evening"
                : date.Hour > 12
                ? "afternoon"
                : "morning";
        }

        public static void ShowDayTime(string result)
        {
            Console.WriteLine(result);
        }
    }
}
