using System;
using System.Collections.Generic;

namespace M007_02_Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Beispiel: Virtual Property
            // 1) [STRG + '.']
            // 2) [Enter]
            List<Lebewesen> lebewesenListe = new List<Lebewesen>();
            lebewesenListe.Add(new Lebewesen());
            lebewesenListe.Add(new Mensch());
            lebewesenListe.Add(new Mitarbeiter());
            lebewesenListe.Add(new Freiberufler());

            foreach (Lebewesen lebewesen in lebewesenListe)
            {
                lebewesen.Alter = 21;
            }

            #endregion

            #region Beispiel2: Virtual Methode
            Console.WriteLine("BEISPIEL 2: Virtual - Methoden");

            List<Shape> geoFormenListe = new List<Shape>();
            geoFormenListe.Add(new Quatrat(7));
            geoFormenListe.Add(new Rectangle(5, 7));

            geoFormenListe.Add(new Circle(4));
            geoFormenListe.Add(new Sphere(7));
            geoFormenListe.Add(new Cylinder(4, 5));

            foreach(Shape aktuelleGeoForm in geoFormenListe)
            {
                Console.WriteLine("Area = {0:F2}", aktuelleGeoForm.GetArea());
            }

            #endregion
        }
    }
}
