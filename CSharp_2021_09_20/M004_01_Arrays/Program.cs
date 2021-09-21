using System;
using System.Linq;
using System.Text; 

namespace M004_01_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://docs.microsoft.com/de-de/dotnet/csharp/programming-guide/arrays/multidimensional-arrays
            #region Eindimensionale Arrays - wird am meisten verwendet
            // 0...4
            int[] zahlen = new int[5]; //ein Integer-Array mit 5 - Elementen 
            zahlen[0] = 3;
            zahlen[1] = 6;
            //...

            //Array wird mit einer Größe von 7 Elementen angelegt
            int[] zahlen2 = new int[] { 3, 6, 9, 12, 15,18, 21 };

            double averageValuze = zahlen2.Average();
            
            
            if (!zahlen2.Contains(12))
            {
                // Datensatz kann hinzugefügt werden und die Eindeutigkeit bleibt gewahrt 
            }

            string csvPattern = "Kevin;Winter;Berlin;Trainer";

            //wird 4 Elemente groß
            string[] csvParts = csvPattern.Split(';');

            Console.WriteLine(csvParts[0]); //vorname
            Console.WriteLine(csvParts[1]); //nachname
            Console.WriteLine(csvParts[2]); //ort
            Console.WriteLine(csvParts[3]); //job beschreibung


            double[] gleitkommzahlen = new double[] { 6.29, 1.58, 4.79, 6.55 };

            //Min/Max -> benötigt System.Linq;
            double kleinsteZahl = gleitkommzahlen.Min(); //kleinster Wert im Array wird herausgegeben
            double hoechsteZahle = gleitkommzahlen.Max();
            double durschnittsWert = gleitkommzahlen.Average();
            double ersteZahl = gleitkommzahlen.First();
            double letzteZahl = gleitkommzahlen.Last();
            double sum1 = gleitkommzahlen.Sum();

            #endregion


            #region Zwei-Dimensionales Array
            int[,] zweiDimensionen; //Deklaration

            //Instanziierung + Initialisierung -> Array ist 2/5 - Felder groß 
            zweiDimensionen = new int[,] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 } };

            //Instanziierung + Initialisierung 
            zweiDimensionen = new int[4, 3];
            zweiDimensionen[0, 0] = 22;
            zweiDimensionen[0, 1] = 33;
            zweiDimensionen[0, 2] = 44;

            zweiDimensionen[1, 0] = 22;
            zweiDimensionen[1, 1] = 44;
            zweiDimensionen[1, 2] = 66;


            zweiDimensionen[2, 0] = 3;
            zweiDimensionen[2, 1] = 6;
            zweiDimensionen[2, 2] = 9;

            zweiDimensionen[3, 0] = 7;
            zweiDimensionen[3, 1] = 14;
            zweiDimensionen[3, 2] = 19;

            for (int x = 0; x < zweiDimensionen.GetLength(0); x++)
            {
                for (int y = 0; y < zweiDimensionen.GetLength(1); y++)
                {
                    Console.WriteLine(zweiDimensionen[x,y]);
                }
            }

            #endregion


            #region 3-Dimensionale Arrays
            int[,,] array3D = new int[2, 3, 2] { { { 1, 2 }, { 3, 4 }, { 5, 6 } }, { { 7, 8 }, { 9, 10 }, { 11, 12 } } };


            //Anzahl der Dimensionen
            int dimensionen = array3D.Rank;//3 -> [2, 3, 2]

            //Anzahl aller Elemente
            int laenge3D = array3D.Length;//12 -> { { { 1, 2 }, { 3, 4 }, { 5, 6 } }, { { 7, 8 }, { 9, 10 }, { 11, 12 } } };


            //Laenge der einzelnen Dimensionen
            int laenge1 = array3D.GetLength(0);//2
            int laenge2 = array3D.GetLength(1);//3
            int laenge3 = array3D.GetLength(2);//2

            #endregion



            #region verzweigte Arrays 

            //Initialisierung durch setzen der Laenge
            int[][] verzweigteArray = new int[4][];

            //Initialisierung durch direkte Zuweisung der Elemente
            verzweigteArray = new int[][] { new int[] { 1, 2, 3 }, new int[] { 1, 2 } };

            //Zugriff ueber Index
            int jaggedWert = verzweigteArray[0][2];// 3
            #endregion


            
        }
    }
}
