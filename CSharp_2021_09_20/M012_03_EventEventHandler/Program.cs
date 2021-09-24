using System;

namespace M012_03_EventEventHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessBusinessLogic businessLogic = new ProcessBusinessLogic();
            businessLogic.CurrentPercentStatus += BusinessLogic_CurrentPercentStatus;
            businessLogic.ProcessCompleted += BusinessLogic_ProcessCompleted;


            businessLogic.StartProcess();





            ProcessBusinessLogic2 processBusinessLogic2 = new ProcessBusinessLogic2();
            processBusinessLogic2.CurrentPercent += ProcessBusinessLogic2_CurrentPercent;
            processBusinessLogic2.ProcessCompleted += ProcessBusinessLogic2_ProcessCompleted;
            processBusinessLogic2.ProcessCompletedNew += ProcessBusinessLogic2_ProcessCompletedNew;
            processBusinessLogic2.ProcessStart();
        }

        private static void ProcessBusinessLogic2_CurrentPercent(object sender, EventArgs e)
        {
            MyPercentArgs myPercentArgs = (MyPercentArgs)e;

            Console.WriteLine($"percent: {myPercentArgs.CurrentPercentValue}");
        }

        private static void ProcessBusinessLogic2_ProcessCompletedNew(object sender, EventArgs e)
        {
            MyEventArgs myEvent = (MyEventArgs)e;
            Console.WriteLine($"Bin fertig um : {myEvent.Uhrzeit}");
        }

        private static void ProcessBusinessLogic2_ProcessCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Bin fertig");
        }

        private static void BusinessLogic_ProcessCompleted()
        {
            Console.WriteLine("Bin fertig");
        }

        private static void BusinessLogic_CurrentPercentStatus(int percent)
        {
            Console.WriteLine($"Prozent: {percent}");
        }
    }
}
