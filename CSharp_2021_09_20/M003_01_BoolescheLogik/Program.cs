using System;

namespace M003_01_BoolescheLogik
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Einstieg in bool 
            bool booleanWahr = true;
            bool booleanFalsch = false;

            // aus True wird 1
            // aus False wäre 0
            int result1 = Convert.ToInt32(booleanWahr); //Result =1 
            int result2 = Convert.ToInt32(booleanFalsch); //result2 = 0


            //Beispiel2:
            int number1 = 1;
            int number2 = 0;

            //aus 1 wird True
            //aus 0 wird False
            bool boolValue = Convert.ToBoolean(number1);
            bool boolValue1 = Convert.ToBoolean(number2);
            #endregion


            #region == und !=
            //ergebnis1 = false
            bool ergebnis1 = booleanWahr == booleanFalsch; //sind beide Ausdrücke gleich
            
            
            //ergebnis2 = true
            bool ergebnis2 = booleanWahr != booleanFalsch; //sind beide Ausdrücke gleich

            //false
            bool ergebnis3 = number1 == number2;

            //true
            bool ergebnis4 = number2 != number1;

            string ersterString = "Inhalt des Strings";
            string zweiterString = "Inhalt des Strings";

            bool ergebnis5 = ersterString == zweiterString; //true
            bool ergebnis6 = ersterString != zweiterString; //false
            #endregion

            #region Vergleichsoperatoren (kleiner, grosser, kleiner-gleich, groesser-gleich)
            //int number1 = 1;
            //int number2 = 0;

            bool ergebnis7 = number1 < number2; // false
            bool ergebnis8 = number1 > number2; // true

            bool ergebnis9 = number1 <= number2; // false
            bool ergebnis10 = number1 >= number2; // true
            #endregion


            //&&:    Ergebnis(true/falae) = (Ausdruck1) == true? && Ausdruck2 == true? 

            //bedingte logische Operatoren (und, oder)
            bool ergebnis13 = booleanWahr && booleanFalsch; //false
            bool ergebnis13a = booleanWahr && booleanWahr && booleanWahr && booleanWahr; //true

            bool ergebnis14 = booleanWahr || booleanFalsch; //true
            bool ergebnis14a = booleanFalsch || booleanFalsch; //false
        }
    }
}
