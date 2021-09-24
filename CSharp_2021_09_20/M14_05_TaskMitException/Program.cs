using System;
using System.Threading;
using System.Threading.Tasks;

namespace M14_05_TaskMitException
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t1 = null, t2 = null, t3 = null, t4 = null;

            try
            {
                //kritischer Codeabschnitt

                t1 = new Task(MachEinenFehler1);
                t1.Start();

                t2 = Task.Factory.StartNew(MachEinenFehler2);

                t3 = Task.Run(MachEinenFehler3);

                t4 = Task.Run(MachKeinenFehler);

                Task.WaitAll(t1, t2, t3, t4); //Ich warte bis alle Tasks fertig sind 


                //Zum späteren Zeitpunkt können wir immer noch nachvollziehen, was mit den Task passiert ist. 

               
            }
            catch(AggregateException ex) // AggregateException wird für Task - Fehler verwendet
            {
                foreach (Exception innerException in ex.InnerExceptions)
                {
                    Console.WriteLine(innerException.Message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


            if (t4.IsCompleted)
                Console.WriteLine("Ist Task fertig durchgelaufen");

            if (t4.IsFaulted)
                Console.WriteLine("Gab es einen Fehler");

            if (t4.IsCanceled)
                Console.WriteLine("Wurde Task abgebrochen?");

            if (t4.IsCompletedSuccessfully)
                Console.WriteLine("Task wurde erfolgreich beendet");

            Console.ReadLine();

        }



        private static void MachEinenFehler1()
        {
            Thread.Sleep(3000);
            throw new DivideByZeroException();
        }

        private static void MachEinenFehler2()
        {
            Thread.Sleep(6000);
            throw new StackOverflowException();
        }

        private static void MachEinenFehler3()
        {
            Thread.Sleep(9000);
            throw new OutOfMemoryException();
        }

        private static void MachKeinenFehler()
        {
            Console.WriteLine("Einen schönen Tag :-) ");
        }
    }
}
