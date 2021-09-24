using System;

namespace M012_02_DelegateAndActionWithCallback
{
    delegate void DoWorkResultDelegate(string msg);


    class Program
    {
        static void Main(string[] args)
        {
            DoWorkResultDelegate doWorkResultDelegate = new DoWorkResultDelegate(FinishResultMethode);
            DoWork(doWorkResultDelegate);

            Action<string> doWorkResultActionDelegate = new Action<string>(FinishResultMethode);
            DoWork(doWorkResultActionDelegate);
        }


        #region DoWork with Delegate

        public static void DoWork(DoWorkResultDelegate resultDelegate)
        {

            //Berechnen wir etwas wichtiges oder greifen auf Ressource z.b SqlServer / WCF oder WebAPI 



            // Ganz am Ende der Methode, müssen wir ein Signal senden, das wir fertig sind oder es z.b Fehler passiert ist. 
            resultDelegate("wir haben erfolgreich die Methode ausgeführt");
        }

        public static void DoWork(Action<string> resultDelegate)
        {
            //Hier wird etwas berechnet






            //und hier erzählen wir das ergebnis nach draußen (innerhalb der selben klassen)
            resultDelegate("Auch ein Action-Delegate kann als Callback verwendet werden");
        }
        #endregion


        public static void FinishResultMethode(string msg)
        {
            //Geben Ergebnis der Berechnung bekannt. 
            Console.WriteLine(msg);
        }
    }
}
