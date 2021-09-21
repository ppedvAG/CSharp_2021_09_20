using System;

namespace M005_01_Methoden_Lehre
{
    class Program
    {
        static void Main(string[] args)
        {

            #region optionale Parameter -
            Console.WriteLine("Hello World!");

            string myWord = "Hello";
            

            Display();
            Display("Hello World");
            Display(myWord.ToCharArray(), 123);
            Display("Hello World", 123);



            //Strings Verbinden - Beispiel
            string[] myStrings = { "eins", "zwei", "drei" };
            
            
            StringVerbinden(myStrings, '-');
            StringVerbinden(myStrings);
            //ergebnis wäre -> eins-zwei-drei


            int result = Addiere(1, 2, 3, 4);

            Addiere(1, 2, 3);
            Addiere(1, 2);

            // Addiere(1); -> Hier wird ein Fehler erscheinen. Parameter 2 MUSS ausgefüllt sein, da er nicht optional ist. 

            #endregion


            #region Params-Parameter
            //Wie war das damals mit Arrays
            int[] meinZahlenArray = { 1, 2, 3, 4 };
            Console.WriteLine(AddiereOld(meinZahlenArray));  //Ergebnis von AddiereOld wird in WriteLine übergeben 


            //Gesegnet sei die .NET Evolutio
            Addieren(1, 2, 3, 4, 5, 6, 7, 8, 9); //
            #endregion


            #region OUT-Paramter 
            //int ist ein Wertetyp
            int myAge = 33; //liegt irgendwo im Speicher und hat eine eiegene Adresse (Pointer) 

            //Methode verwendet Parameter als Werteobject (int) 
            Altern(myAge); //Wertetypen übergeben immer eine KOPIE
            Console.WriteLine(myAge); //bleiben quasi auf 33 Jahren stehen 

            //OUT - Parameter -> OUT hat eine Bedinung -> es muss innerhalb einer Methode, einen Wert zugewiesen bekommen. 

            ChangeAge(out myAge, 40); //Wertetype wird wie ein Referenztyp behandelt -> Die Speicheradresse wird in diesem fall übergeben
            Console.WriteLine(myAge); //Das modifizieren innheralb ChangeAge, bekommen wir immer noch via MyAge mit (selbe Speicheradresse)

            string myNumber = "123";
            int myRetValue;

            if (int.TryParse(myNumber, out myRetValue))
            {
                //Wenn ich bis hier her komme, ist das casten valide
                //UND myRetValue wurde innerhalb in TryParse gecastet und hat den Wert von myNumber erhalten (Bedienung für Out)
                Console.WriteLine(myRetValue);
            }
            #endregion


            #region IN - Parameter -> In Parameter ist nur readonly 
            DisplayAge(in myRetValue);
            #endregion
        }


        #region Überlagern von Methoden

        //Was ist eine Methoden Signagur 

        // Rückgabetyp -> Welcher Typ wird zurück gegeben (void/int/float/bool/string  oder ein komplexe Objekt (class, record, struct....) 
        // Methodennamen (Prio1) -> 
        // Parameterliste -> Welche Werte benötige ich für eine Berechnung -> Dies wird in ein oder mehrere Parameter gefasst
        // Ein Parameter kann (void/int/float/bool/string  oder ein komplexe Objekt (class, record, struct....) 


        static void Display() //void als Paremterlist -> geht auch
        {
            Console.WriteLine("Default-Text");
        }


        static void Display (string message)
        {
            Console.WriteLine($"{message}");
        }


        //Wenn zweite Display - Methode die selben Paramterliste vorweist -> erhalten wir folgenden Fehler
        //-> https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0111?f1url=%3FappId%3Droslyn%26k%3Dk(CS0111)

        static void Display(string message, int errorCode)
        {
           /* Display(message); *///Verwenden wir nur die vorhande Methoden-Struktur, bei der nur ein Message - Paramter verwendet

            Console.WriteLine($"ErrorCode: {errorCode}");
        }

        static void Display(char[] message, int errorCode)
        {
            Console.WriteLine($"{message} - ErrorCode: {errorCode}");
        }

        #endregion

        #region Optionale Paramter 
        //static string StringVerbinden(string[] strings)
        //{
        //    return "Test";
        //}


        static string StringVerbinden(string[] strings, char trenner = '*')
        {
            string resultString = strings.Length > 0 ? strings[0] : throw new ArgumentException("StringVerbinden - Paramter: strings -> wurde nicht befüllt");
            
            ////weitere Variante - wenn Parameter nicht richtig befüllt werden, kann ich alternativ zu einer Exception auch ein leerString zurück gebgen und diesen auf String.Empty prüfen (im Fehlerfall) 
            //string resultString1 = strings.Length > 0 ? strings[0] : string.Empty);
            //if (resultString1 == string.Empty)
            //    return string.Empty;



            for (int i=1; i <strings.Length; i++)
            {
                resultString += (trenner + strings[i]);

            }

            return resultString;

        }

        
        static int Addiere (int zahl1, int zahl2, int zahl3 = 123, int zahl4 = 456)
        {
            return zahl1 + zahl2 + zahl3 + zahl4;
        }
        #endregion

        #region Params 
        static int Addieren(params int[] zahlen)
        {
            int summe = 0;

            for (int i = 0; i < zahlen.Length; i++)
                summe += zahlen[i];

            return summe;
        }

        static int AddiereOld(int[] zahlen)
        {
            int summer = 0;

            for (int i = 0; i < zahlen.Length; i++)
                summer += zahlen[i];

            return summer;
        }

        #endregion

        #region OUT-Parameter

        static void Altern(int theAge) //theAge ist eine Kopie
        {
            theAge++;
        }

        static void ChangeAge(out int theAge, int modifiedAge)
        {
            //theAge - Zuweisung muss erfolgen!!!!!!
            theAge = modifiedAge; // out-dürfen nicht lesbar sein. 

            //Methode ohne Zuweisung -> Compiler Error CS0177
            //-> https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0177?f1url=%3FappId%3Droslyn%26k%3Dk(CS0177)
        }
        #endregion

        #region IN-Paramter
        static void DisplayAge(in int myReadonlyNumber)
        {
            //myReadonlyNumber++; //-> Error CS8331 -> 


            Console.WriteLine(myReadonlyNumber);

            //newVariable ist eine Kopie 
            int newVariable = myReadonlyNumber;

        }
        #endregion

        #region Ref-Parameter
        //Allgemeine Referenz ohne Regeln (muss überschrieben werden oder ist nur readonly) 
        static void MethodeWithNormalReference(ref int myNumberReference)
        {
            //myNumberReference++;

        }

        #endregion
    }
}
