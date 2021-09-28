using System;

namespace Wiederholung_OOP_ValueTypesVsReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Was ist ein Wertetyp;
            //bool, byte, short, int, long ....
            //float, double, decimal 
            //struct -> 

            //Einfaches Smaple1
            int sample1Value = 5;
            OffSet10Value(sample1Value); //Hier wird eine Kopie übergeben!!!!
            Console.WriteLine(sample1Value); //Wurde der Wert erhöht. 

            OffSet10ValueWithOut(ref sample1Value); //Hier verwenden wir einen Wertetyp, wie einen Referenztyp
            Console.WriteLine(sample1Value);

            //http://www.devsanon.com/c/c-7-2-introducing-ref-struct/

            Point point = new Point();
            point.X = 3;
            point.Y = 3;
            ChangeStruct(point); //Kann ein Struct wie ein Referenztyp verwendet werden?
            Console.WriteLine(point.X);


            ChangeStruct2(ref point);
            Console.WriteLine(point.X);

            //Performance bei Struts 

            //Kopiert alle Properties 1:1 nach point1.
            //Bedeutet: 9x eine Zuweisung (kopie) 
            Point  point1 = point;

            Console.WriteLine(point1.X);

            //Reference Types
            //string (!!!), class, interfaces, records, 

            //Ausnahme String!!!!
            string inputString = "abcdefg";
            ToUpperMyString(inputString);
            Console.WriteLine(inputString);




            //Beispiel 1. Klasse wird als Parameter übergeben 
            NumberWapperClass wapperClass = new() { MyPublicVariable = 3, MyNumber = 5 };
            
            OffSet20Values(wapperClass); //<- Übergebe die Adresse von wapperClass. 
            Console.WriteLine(wapperClass.MyNumber);



          

            //array? 
        }


        public static void OffSet10Value(int number)
        {
            number += 10;
        }
        public static void OffSet10ValueWithOut(ref int number)
        {
            number += 10;
        }

        public static void OffSet20Values(NumberWapperClass wapperClass)
        {
            wapperClass.MyNumber += 11;
            wapperClass.MyPublicVariable += 17;

            wapperClass.TestString = wapperClass.TestString.ToUpper();
        }

        public static void ToUpperMyString(string str)
        {
            str = str.ToUpper();
        }

        public static void ChangeStruct(Point point)
        {
            point.X = 11;
            point.Y = 22;
        }

        public static void ChangeStruct2(ref Point point)
        {
            point.X = 11;
            point.Y = 22;
        }

    }


    public class NumberWapperClass
    {
        public int MyNumber { get; set;  }

        public int MyPublicVariable;

        public string TestString = "abcedf";
    }


    public ref struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }
        public int E { get; set; }
        public int F { get; set; }
        public int G { get; set; }


    }
}
