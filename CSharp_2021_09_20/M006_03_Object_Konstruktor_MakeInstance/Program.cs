using System;

namespace M006_03_Object_Konstruktor_MakeInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Default-Konstruktor -> wird beim kompilieren hinzugefügt
            Car car = new Car();


            //Default-Konstuktor -> wurde manuell erstellt ( siehe Konstuktor->Car2() ) 
            Car2 car2 = new Car2();

            //Werte-Konstruktor 
            Car2 carWithValues = new Car2("VW", "Polo", 2001, new int[5] { 1, 2, 3, 4, 5 });


            Car2 neueCarVerionMitFarbe = new Car2("VW", "Polo", 2001, new int[5] { 1, 2, 3, 4, 5 }, "gelb");


            
        }
    }
}
