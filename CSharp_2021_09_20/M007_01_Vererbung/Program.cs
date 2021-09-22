using System;
using System.Collections.Generic;

namespace M007_01_Vererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lebewesen -> Freiberufler 
            Lebewesen lebewesen = new Lebewesen();
            lebewesen.Alter = 12;
            lebewesen.Atmen();
            lebewesen.Essen();
            lebewesen.Schlafen();


            Mensch mensch = new(33, "Köln");
            mensch.Essen();
            mensch.Atmen();
            mensch.Schlafen();
            mensch.Lesen();


            Mitarbeiter mitarbeiter = new(22, "Köln", "ppedv", true, 30);
            //Property + Methoden sind aus der Klasse: Lebewesen
            mitarbeiter.Atmen();
            mitarbeiter.Essen();
            mitarbeiter.Schlafen();

            //mitarbeiter.Wohnort = "Köln"; //Property + Methoden sind aus der Klasse: Mensch
            mitarbeiter.Lesen();

            mitarbeiter.Arbeitgeber = "ppedv";
            mitarbeiter.ArbeitszeitVon = new DateTime(2021, 8, 23, 9, 0,0);
            mitarbeiter.ArbeitzeitBis = new DateTime(2021, 8, 23, 17, 0, 0);

            Freiberufler freiberufler = new Freiberufler(19, "Hamburg", "Spiegel Verlag");
            freiberufler.Auftraggeber = "Telekom";
            freiberufler.Alter = 43;
            freiberufler.Wohnort = "Bonn";
            #endregion


            List<Lebewesen> listeLebewesen = new List<Lebewesen>();
            listeLebewesen.Add(lebewesen);
            listeLebewesen.Add(mensch);
            listeLebewesen.Add(mitarbeiter);
            listeLebewesen.Add(freiberufler);


            foreach(Lebewesen currentLebewesen in listeLebewesen)
            {
                currentLebewesen.Atmen(); //Hier gehen alle auf die Basis-Klasse implementierung, weil es hier kein override gibt
            }

            
        }
    }
}
