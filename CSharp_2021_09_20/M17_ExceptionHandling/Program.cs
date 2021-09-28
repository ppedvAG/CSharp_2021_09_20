using System;

namespace M17_ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = null;

            try
            {
                DivideByZeroException zeroException = new DivideByZeroException();

                if (zeroException is Exception ex)
                {

                }
                //Hier könnte ein Fehler passieren
                //calculator = new Calculator();
                double result = calculator.Divide(5, 0);
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"ToString() - {ex.ToString()}");
                Console.WriteLine($"Message() - {ex.Message}");
                Console.WriteLine($"StackTrace() - {ex.StackTrace}");
                //....
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"ToString() - {ex.ToString()}");
                Console.WriteLine($"Message() - {ex.Message}");
                Console.WriteLine($"StackTrace() - {ex.StackTrace}");
                //...
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ToString() - {ex.ToString()}");
                Console.WriteLine($"Message() - {ex.Message}");
                Console.WriteLine($"StackTrace() - {ex.StackTrace}");
            }

            finally
            {
                //Für Aufräumarbeiten 
            }


        }
    }


    public class Calculator
    {
        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
                throw new DivideByZeroException(); //Hier schmeißen wir einen Fehler

            return dividend / divisor;
        }
    }
}
