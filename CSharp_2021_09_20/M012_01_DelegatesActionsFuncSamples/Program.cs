using System;

namespace M012_01_DelegatesActionsFuncSamples
{

    //delegate ist ein Typ und arbeitet mit Methoden zusammen
    //-> Ich kann mit Methoden zusammenarbeiten, die den selben Aufbau haben, wie bei mir.
    delegate int NumbChange(int n);

    delegate int CalculationDelegate(int a, int b);
    //Bei Delegates werden die Definitionen sehr viel werden

    class Program
    {
        static void Main(string[] args)
        {

            #region Delegate mit einem Parameter(int) und einem Rückgabewert(int)
            NumbChange numbChange = new NumbChange(AddNumber); //(Funktionszeiger) zeigt aus Startpunkt der Methode
            numbChange += SubNumber; //Hier hängen wir die zweite Methode SubNumber dran.

            //Führen die Methode AddNumber + SubNumber aus! Nur SubNumber liefert einen Returnwert zurück, weil diese als letzte Methode aufgerufen wurde
            int result = numbChange(11);

            numbChange -= AddNumber; //Wir entnehmen die Methode AddNumber vom delegate
            numbChange(15); // -> SubNumber wir jetzt aufgerufen
            #endregion

            #region Delegate mit zwei Parameter(int/int) und einem Rückgabewert (int)
            CalculationDelegate calculationDelegate = new CalculationDelegate(Addiere);
            result = calculationDelegate(11, 7);
            #endregion


            #region Action 

            //Vergleich zu einem Delegate. Action ist eine Wapper-Klasser um einem Delegate.

            Action a1 = new Action(A); //Funktionszeiger der Methode würd übergeben
            a1(); // MethodeA wird aufgerufen 

            a1 += B;
            a1(); // Methode A wird zuerst ausgeführt, danach Methode B

            a1 -= A; //Methode A wird abgehängt 
            a1(); // Methode B wird ausgefürt. 


            //Action mit Parameter 

            //Actions können nur Methoden aufrufen die ein void zurückgeben
            Action<int> weCallMethodeC = new Action<int>(C);
            weCallMethodeC(12);

            Action<decimal, decimal> theActionForTheDecimals = new Action<decimal, decimal>(Addiere);
            theActionForTheDecimals(11, 12);
            #endregion

            #region Func
            Func<int, int, double> func = new Func<int, int, double>(Dividiere);
            double result2 = func(12, 5);

            #endregion
        }

        //Diese Methode im Speicher eine Startpunkt 
        public static int AddNumber(int number)
        {
            return number += 5;
        }

        public static int SubNumber(int number)
        {
            return number -= 5;
        }

        public static int Addiere (int a, int b)
        {
            return a + b;
        }

        public static double Dividiere(int a, int b)
        {
            return a / b;
        }


        public static void A()
        {
            Console.WriteLine("A");
        }

        public static void B()
        {
            Console.WriteLine("B");
        }
        public static void C(int zahl)
        {
            Console.WriteLine("Methode-C: " + zahl);
        }


        public static void Addiere(decimal a, decimal b)
        {
            Console.WriteLine(a+b);
        }
    }
}
