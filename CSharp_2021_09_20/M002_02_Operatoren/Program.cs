using System;

namespace M002_02_Operatoren
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl1 = 4;
            int zahl2 = 2;

            //Rechengrundarten
            int addition = zahl1 + zahl2;
            int subtraktion = zahl1 - zahl2;
            int multiplikator = zahl1 * zahl2;
            int division = zahl1 / zahl2;


            #region Modulo
            //Was ist Modulo? % 
            //13 % 5 = 2 Rest: 3
            int zahl3 = 14;
            int zahl4 = 3;

            //Modulo == 2
            int modulo = zahl3 % zahl4;




            //  Zufallsgenerator
            Random random = new Random();
            
            //0 ...2 Mrd
            int randomNumber = random.Next();

            //Meine Zufallszahl soll zwoschen 1..99
            int numberBetweenZeroAndHundred = randomNumber % 100;

            //1..493
            int randomNumber2 = random.Next(1, 49);
            #endregion


            #region Inkrementieren / Dekrementieren / Verkürzte Schreibweisen
            int myNumber = 10;
            int mySecondNumber = 10;
            myNumber++; //Number wird um den Wert 1 erhöht.  Ausgeschrieben Form : myNumber = myNumber + 1;
            myNumber = 10;

            Console.WriteLine(myNumber++); //Zuerst wird Zahl ausgegeebn (10) und danach wird erhöht
            Console.WriteLine(++mySecondNumber); // Zuerst wird Zahl erhöht (11), danach die Zahl augegegen

            //Subraktionsbeispiel:
            myNumber--; //subtrahiert den Wert um 1 

            myNumber = myNumber + 5;//erhöhe um 5
            myNumber += 5; //erhöhe um 5

            //Mulitplikationsbeispiel in verkürzter Form
            int x = 5;
            x *= 7; //35
            #endregion

            #region Kleitkommazahlen Runden
            double erg1 = Math.Round(8.89); //kaufm. Runden => 5
            double erg2 = Math.Ceiling(4.14); //wird immer aufgerundet 
            double erg = Math.Floor(4.76); // wird immer abgerundet


            double erg3 = Math.Round(0.33333333333, 2);

            Console.WriteLine(Math.Round(0.33333333333, 2));
            Console.WriteLine($"Rundung nach zweiten Kommastelle: {erg3}"); 

            decimal kommaRundung = decimal.Round(3.156m, MidpointRounding.ToEven);


            Console.WriteLine("Beispiel - Rundungs Szeario mit einer for schleife: ");
            
            for (decimal value = 100m; value <= 102m; value += .1m)
                Console.WriteLine("{0} --> {1}", value, decimal.Round(value));
            #endregion

        }
    }
}
