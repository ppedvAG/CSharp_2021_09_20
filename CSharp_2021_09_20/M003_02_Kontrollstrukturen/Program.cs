using System;

namespace M003_02_Kontrollstrukturen
{
    class Program
    {
        static void Main(string[] args)
        {

            //Beispiel 1: 
            Console.Write("Gib den Akkustand ein: ");

            int akkuStand = int.Parse(Console.ReadLine());
            bool akkuInLoading = true; 


            string akkuStandMessage = string.Empty; //akkuStand = "";

            if (akkuStand > 20 && akkuStand <= 100) //&& wenn alle Vergleiche true ergeben
                                                    // akkuStand > 20  
                                                    // akkuStand <= 100
            {
                akkuStandMessage = "Akku ist in Ordnung";
            }
            else if (akkuStand > 0 && akkuStand <= 20 && akkuInLoading==false) //kü
            {
                akkuStandMessage = "Akku soll demnächst geladen werden";
            }
            else if (akkuStand == 0)
            {
                akkuStandMessage = "Akku ist leer";
            }
            else
            {
                akkuStandMessage = "Akku defekt";
            }

            //Beispiel 2: 
            int myNumber = 33;

            // Condition ? wahr-block : else-block;
            bool result = myNumber == 33 ? true : false;
            string message = myNumber == 35 ? "myNumber ist 35" : "myNumber ist keine 35";

            //Beispiel 3:
            DateTime dateTime = new DateTime(2003, 5, 10);
            message = string.Empty;

            switch(dateTime.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    message = "bin vom Wochenende noch müde";
                    break; // bei dem break, verlasse ich das switch Statement 
                case DayOfWeek.Tuesday:
                    message = "Dienstags arbeite ich alles auf";
                    break;
                case DayOfWeek.Wednesday:
                    message = "Mittwoch arbeite ich bis 12 Uhr";
                    break;
                case DayOfWeek.Thursday: // -> gehe in den Case-Block von Freitag 
                case DayOfWeek.Friday:
                    message = "Do & Fr -> arbeiten nur noch minimalistisch";
                    break;
                default:
                    message = "Wochehende";
                    break;
            }
            // kommen von break 


            Console.Write("Gebe Obst ein: ");
            string obst = Console.ReadLine();
            string farbe = string.Empty;

            switch (obst)
            {
                case "Kirsche":
                    farbe = "rot";
                    break;
                case "Banane": //wenn obst == "Banane" ->  die kommende Anweisung ausfuehren
                case "Zitrone":
                    farbe = "gelb";
                    break;
                case "Orange":
                    farbe = "orange";
                    break;
                default:
                    farbe = "unbekannt";
                    break;


            }

            Console.WriteLine($"Obst: {obst} - Farbe: {farbe}");
            Console.ReadLine();
        }
    }
}
