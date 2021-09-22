using System;
using System.Collections.Generic;

namespace M007_03_abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //BaseClass baseClass = new BaseClass(); //von abstrakten Klassen kann man keine Instanz erzeugen -> Compiler Error CS0144 ->https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0144?f1url=%3FappId%3Droslyn%26k%3Dk(CS0144)
            List<Shape> geoformenListe = new List<Shape>();

            geoformenListe.Add(new Circle());
            geoformenListe.Add(new Square(7));

            foreach(Shape currentShape in geoformenListe)
            {
                Console.WriteLine("Area = {0:F2}", currentShape.GetArea());
            }
        }
    }
}
