using System;

namespace Modul002_01_Datentypen
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Datentypen die mit Zeichen oder Zeichenketten arbeiten -> char /string 
            
            
            //BEISPIEL1: Darstellen von Zeichen (basiert auf Ascii-Tabelle)
            char textzeichen = 'A';
            //cw + tab + tab
            Console.WriteLine(textzeichen);


            string eineZeichenkette = "Hallo Liebe Teilnehmer, willkommen im C# - Kurs";
            Console.WriteLine(eineZeichenkette);

            //BEISPIEL2: Escape-Zeichen in string -> https://docs.microsoft.com/de-de/dotnet/standard/base-types/character-escapes-in-regular-expressions

            string stringMitEscapeZeichen = "Hallo Liebe Teilnehmer \n Willkommen in CSharp-Kurs \t der Kurs geht 5-6 Tage";



            //BEISPIEL3: Wie kann ich Pfade in einen String darstellen 

            string dateiPfad = "C:\\Windows\\Temp\\123"; //Old School Variabte -> Um das Backslash in einen String zu platzieren musste man 2x Backslah nacheinander schreiben

            string dateiPfade2 = @"C:\Windows\Temp\123"; //korrekter Windowspfad  + Excape Zeichen wurden ausgeschaltet


            #endregion


            bool boolVariable = true;
            boolVariable = false;



            #region Nummerische Datentypen
            byte minByte = 0;
            byte maxByte = 255;
            Console.WriteLine(minByte);

            byte giveMeLowestByteValue = byte.MinValue;
            byte giveMeHihestByteValue = byte.MaxValue;

            //16-Bit
            short minShort = short.MinValue;
            short maxshort = short.MaxValue;

            //32 Bit 
            int minInt = int.MinValue;
            int maxInt = int.MaxValue;

            //64-Bit
            long minLong = long.MinValue;
            long maxLong = long.MaxValue;
            #endregion


            #region Gleitkomma Datentypen

            double doubleValue = 69.65;
            
            float floadValue = 12.2345f; //suffix f zeigt an, dass der Wert in eine Float-Struktur übertragen wird 


            //decimal ist für Geldbeträge ausgelegt und Microsoft legt juristisch die Hand dafür ins Feuer. 
            decimal geldbreat = 12345m; //suffix 'm' ist bei Geldbeträgen wichtig. Das Suffix m wird nur bei decimal verwendet. 
            #endregion


            #region Wertetypen und Referenztypen
            //Wertetypen: (übergeben immer eine Kopie) 
            // -> int, byte, short, long (alle nummerische Werte)
            // -> bool 
            // -> Gleitkomma Datentypen float, double, decimal; 
            // -> char
            // -> struct 

            //Referenztypen (Referenztypen geben ihre Speicheradresse weiter)
            // - string ist offiziell ein Referenztyp -> Verhält sich aber wie ein Wertetype
            // - class  -> alles was objekte sind
            // - interface
            // - record
            #endregion



            #region Nullable Datentypen  //-> https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/builtin-types/nullable-value-types
            int xyz; // wenn kein Wert zugewiesen wird, dann ist xyz -> 0 


            int? abc = null; // null - Zuordnung

            if (abc.HasValue)
            {
                Console.WriteLine("Habe einen Wert" + abc + abc.Value);
            }
            else
                Console.WriteLine("Variable abc ist (null)");

            abc = 123;

            if (abc.HasValue)
            {
                Console.WriteLine("Habe einen Wert" + abc.Value);
            }
            else
                Console.WriteLine("Variable abc ist (null)");

            //Alternative 

            if (abc != null)
            {
                Console.WriteLine("Habe einen Wert" + abc.Value);
            }
            else
                Console.WriteLine("Variable abc ist (null)");
            #endregion



            #region Native .NET Framework Datentypen vs. C# - Datentypen
            //C# Tadtentyp 
            int def = 123;

            Int32 int32 = 456; 


            #endregion
        }


        #region Use-Case für nullable Datentypen

        static int MethodeA(int? value1, int? value2)
        {
            if (!value1.HasValue)
                throw new ArgumentException();

            if (value2.HasValue == false)
            {
                throw new ArgumentException("Parameter value2 in Methode: 'MethodeA' hat keine Wert übergeben bekommen");
            }


            return value1.Value + value2.Value;
        }
        #endregion
    }
}
