using System;

namespace M002_03_ParsenCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl1 = 25;


            #region Implizit / Expizit -> int -> string

            //Implizit
            string satz1 = "Wert der Zahl: " + zahl1; //Im Hintergunrd wird ToString() aufgerufen 

            //Explizit
            string satz2 = "Wert der Zahl: " + zahl1.ToString();
            #endregion



            #region string -> int
            Console.Write("Autopreis : ");

            string autoPreisEingabe = Console.ReadLine(); //Zahl wird als string gespeichert. 


            //Variante 1
            //Convert.ToInt32 und int.Parse gehen davon aus, dass der string - Parameter auch eine valide Zahl entspricht.
            int preis1 = Convert.ToInt32(autoPreisEingabe);
            
            //Variante 2
            int preis = int.Parse(autoPreisEingabe); //Intern wird Convert.ToInt32 

            //Variante 3 (die sicherste Variante) 
            int preis3;

            //Wird geprüft, ob autoPreisEingabe eine Zahl ist
            if (int.TryParse(autoPreisEingabe, out preis3))
            {
                //AutoPreisEingabe ist eine Zahl 
                Console.WriteLine($"Variablenausgabe: {preis3}");
            }

            #endregion



            string zahlenwort2 = "123,456";
            float zahl4 = float.Parse(zahlenwort2);

            //Single ist der Native .NET Datentyp. In C# kennen wir diesen Typ als ein float
            float zahl5 = Single.Parse(zahlenwort2);

            int kommaWirAbgeschnitten = (int)zahl4; //123 wird nur zugewiesen


            decimal decimalValue = 123.12345678912345678912345m;
            double doubleValue = (double)decimalValue;

        }
    }
}
