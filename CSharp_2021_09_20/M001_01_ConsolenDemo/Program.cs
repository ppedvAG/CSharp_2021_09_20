using System;

namespace M001_01_ConsolenDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Args-Ausgabe
            //wurden argument übergeben
            if (args.Length > 0)
            {
                for (int i = 0; i < args.Length; i++)
                    Console.WriteLine(args[i]);
            }
            #endregion

            #region Write
            Console.Write("Text ohne abschlienenden Zeilenumbruch");
            Console.Write("Und dieser Text, steht auch in der selben Zeile");
            #endregion

            #region WriteLine
            //Kurzschreibweise -> cw + tab + tab

            Console.WriteLine("Schreibe eine Ausgabe und danach wird automatisch ein Zeilenumbruch ausgeführt");
            Console.WriteLine("Ich stehe neue Zeile");
            #endregion


            #region Einfache Eingabe (write/readline)
            Console.Write("Wie teuer darf ein Hotelzimmer sein: ");
            string zimmerPreis = Console.ReadLine();

            //Für eine Einfache Ausgabe benutz man WriteLine 
            int variableDesTage = 123;
            Console.WriteLine("Zimmerpreis ist: " + zimmerPreis );
            Console.WriteLine("Zimmerpreis: {0} und Zahl des Tage ist {1}", zimmerPreis, variableDesTage);
            Console.WriteLine($"Zimmerpreise: {zimmerPreis}");
            #endregion

            #region ReadKey
             
            Console.Clear(); //CLS

            Console.WriteLine("##### ReadKey - Beispiel #####");
            Console.WriteLine("(1) Menüpunkt A");
            Console.WriteLine("(2) Menüpunkt B");
            Console.WriteLine("(3) Menüpunkt C");
            Console.WriteLine("(x) Exit");

            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();

            // Zeilenumbruch muss hier geschehen. 
            
            
            if (consoleKeyInfo.Key == ConsoleKey.D1 || consoleKeyInfo.Key == ConsoleKey.NumPad1)
            {
             // Gibt der Console an, dass diese einen Zeilenumbruch machen darf
                Console.WriteLine(Environment.NewLine + "Menü1 wurde angewählt");
            }

            if (consoleKeyInfo.Key == ConsoleKey.D2 || consoleKeyInfo.Key == ConsoleKey.NumPad2)
            {
                Console.WriteLine("\nMenü2 wurde angewählt"); // \n escape-zeichen -> text mit formatieren 
            }

            if (consoleKeyInfo.Key == ConsoleKey.D3 || consoleKeyInfo.Key == ConsoleKey.NumPad3)
            {
                Console.WriteLine("\nMenü2 wurde angewählt");
            }

            if (consoleKeyInfo.Key == ConsoleKey.X)
                return; // Programm wird beendet

            #endregion









        }
    }
}
