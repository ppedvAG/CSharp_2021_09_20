using System;
using System.Threading.Tasks;

namespace M14_09_AyncAwaitSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Task<string> task = Task.Run(DayTime);
            //Folgetask Variante mit myTask 
            Task myTask = task.ContinueWith(task => ShowDayTime(task.Result), TaskContinuationOptions.OnlyOnRanToCompletion);
            myTask.Wait();

            //Folgetask Variante mit await
            await task.ContinueWith(task => ShowDayTime(task.Result), TaskContinuationOptions.OnlyOnRanToCompletion);


            //komplett auf async/await unmgestellt -> NAchteil TaskContinuationOptions können nicht angewendet werden
            string coolerReturnValue = await Task.Run(DayTime);
            await Task.Run(() => ShowDayTime(coolerReturnValue));

            Console.WriteLine("Asynchrone Rückgabetypen");

            Task<int> result = GetLeisureHoursAsync();

            var getLeisureHoursTask = GetLeisureHoursAsync();
            string message = $"Today is {DateTime.Today:D}\n" + "Today's hours of leisure: " + $"{await getLeisureHoursTask}";


            Console.WriteLine($"{message}");
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

        //Asynchrone Rückgabetypen
        static async Task<int> GetLeisureHoursAsync()
        {
            DayOfWeek today = await Task.FromResult(DateTime.Now.DayOfWeek);

            int leisureHours =
                today is DayOfWeek.Saturday || today is DayOfWeek.Sunday
                ? 16 : 5;

            return leisureHours;
        }
    }
}
