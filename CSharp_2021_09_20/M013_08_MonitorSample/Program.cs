using System;
using System.Threading;

namespace M013_08_MonitorSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void KritischerCodeAbschnitt() //Diese Methode soll von einem Thread verwendet werden 
        {
            int x = 1; // x muss auf 1 gesetzt werden 


            Monitor.Enter(x); //Hier darf nur ein Thread rein 
            //Kitischer Codebereich -> Beginnt hier
            try
            {
                //callen weitere Methoden 
                //if-else Struktur
            }
            finally
            {
                //Kritischer CodeBereich endet hier
                Monitor.Exit(x); //Variable x wird zurückgesetzt, damit zweiter Thread in den kritischen CodeBereich darf
            }
        }
    }
}
