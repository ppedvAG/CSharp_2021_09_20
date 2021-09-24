using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M013_07_LockSample
{
    public static class Konto
    {
        public static decimal Kontostand { get; set; } = 0;
        public static int TransactionsId { get; set; } = 0; //TransactionsId wird pro Transaction um den Wert 1 erhöht. 

        public static object lockObjectEinzahlen = new object();
        public static object lockObjectAuszahlen = new object();

        public static void Einzahlen(decimal betrag)
        {
            try
            {
                //weitere Threads, müssten hier warten, bis der Thread im lock-Bereich alles fertig abgearbeitet hat. 
                //Nachdem der vorige Thread den lock-Bereich abgearbeitet hat, darf der nächste Thread den Lock-Bereich betreten 

                lock (lockObjectEinzahlen)
                {
                    //In diesem Bereich kann jetzt nur noch ein Thread arbeiten. 
                    TransactionsId++;
                    Console.WriteLine($"Kontostand vor dem Einzahlen: {Kontostand}");
                    Kontostand += betrag; //Wenn sich hier zwei Thread begegnen -> wird eine Deadlock Exception geworfen -> dieser Fehler ist unregelmäßig
                    Console.WriteLine($"Id{TransactionsId}:  Kontostand nach dem Einzahlen: {Kontostand}");
                }
                
            }
            catch (Exception ex)
            {
            }
        }


        public static void Abheben(decimal betrag)
        {
            try
            {
                lock (lockObjectAuszahlen)
                {
                    TransactionsId++;
                    Console.WriteLine($"Kontostand vor dem Auszahlen: {Kontostand}");
                    Kontostand -= betrag; //Ressourcenzugriff. (Wenn mehrere Thread gleichzeitig auf die Variable Kontostand zugreifen...bzw schreiben möchten, gibt es ein Dead-Lock
                    Console.WriteLine($"Id{TransactionsId}:  Kontostand nach dem Auszahlen: {Kontostand}");
                }
            }
            catch (Exception ex)
            {

            }
            

        }
    }
}
