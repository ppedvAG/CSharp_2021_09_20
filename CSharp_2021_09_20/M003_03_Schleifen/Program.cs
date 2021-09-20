using System;

namespace M003_03_Schleifen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inkrementale for-Schleife");
            Console.WriteLine("Ausgabe 1");
            
            for ( int i = 0; i < 10; i++)
                Console.WriteLine(i); //0, 1, 2, 3, 4, 5, 6, 7, 8, 9
            
            Console.WriteLine("Ausgabe 2");
            
            for (int i = 10; i > 0; i--) // 10, 9, 8, 7, 6, 5, 4, 3, 2, 1,
                Console.WriteLine(i);




            Console.WriteLine("Schleife mit Array");
            int[] zahlen = new int[] {  };
            Console.WriteLine("Ausgaben der Primzahlen: ");
            //Gehe das Array komplett durch
            for (int index = 0; index < zahlen.Length; ++index)
            {
                Console.WriteLine(zahlen[index]);
            }

            //Console.WriteLine(zahlen[50]); //Wenn Index ausserhalb des Arrays sich befindet, dann erhalte ich einen Fehler
            // IndexOutOfRangeException

            Console.WriteLine("foreach Schleife");
            foreach (int currentIntegerValue in zahlen)
            {
                //In einer foreach Schleife erhält man keine IndexOutOfRangeException
                Console.WriteLine(currentIntegerValue);
            }

            #region while Schleife

            int n = 0;

            while (n < 5)//Condition 
            {
                Console.WriteLine(n);  //Solange n kleiner als 5 ist, komme ich in den While-Body
                n++;
            }


            bool endlosschleife = true;
            int counter = 0;


            while (endlosschleife)
            {
                Console.WriteLine(counter);

                if (counter == 1000)
                {
                    endlosschleife = false;
                    Console.WriteLine("Set Bedienung auf false");
                }
                counter++;
            }
            Console.WriteLine("While Schleife wurde verlassen");
            Console.ReadKey(true);
            Console.Clear();

            counter = 0;

            while (true) //Endlosschleife
            {
                Console.WriteLine(counter);
                if (counter == 1000)
                {
                    Console.WriteLine("Führe break aus....");
                    break; //Verlassen die Schleife
                }
                counter++;
            } 
            Console.WriteLine("While Schleife wurde verlassen");


            #endregion



            counter = 0;

            do
            {
                if (counter == 1000)
                    break;
                
                Console.WriteLine(counter++); //erst ausgeben und danach hochzählen 
            } while (true); //Fussgesteuerte Schleife



            #region Continue-Befehl in Schleifen 

            for (int i = 1; i < 1000; i++)
            {
                if (i % 7 != 0)
                    continue; //gehe einfach in den nächsten Schleifendurchlauf


                //7er Zahlen werden hier ausgegeben 
                Console.WriteLine($"{i}");

            }

            #endregion




            for (int i = 0; i < 10; i++)
            {
                if (i > 5)
                    break; // Springe aus der Schleif

                Console.Write($"{i}, ");

                for (int x = 0; x < 30; x++)
                {
                    if (x > 5)
                    {
                        break; //Springe aus meiner Inneren For-Schleife heraus 
                    }
                }
                //also hier hin
            } //von break springe ich hier hin 
        }
    }
}
