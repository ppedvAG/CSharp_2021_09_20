using System;
using System.Collections.Generic;

namespace M007_04_Typpruefung
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
            mitarbeiter.ArbeitszeitVon = new DateTime(2021, 8, 23, 9, 0, 0);
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


            foreach (Lebewesen currentLebewesen in listeLebewesen)
            {
                #region Prüfen mit GetType == typeof(T);
                //Was bist du für eine Klasse (Typ) 
                //Type type = currentLebewesen.GetType();
                //Console.WriteLine(type.ToString());




                //if (currentLebewesen.GetType() == typeof(Mensch))
                //{
                //    if (currentLebewesen.GetType() == typeof(Lebewesen))
                //    {
                //        //Kann GetType -> Vererbung verstehen -> 
                //    }
                //    else
                //    {
                //        Console.WriteLine(typeof(Lebewesen));
                //    }
                //}
                #endregion

                #region Is-Operator

                if (currentLebewesen is Mensch) 
                {
                    if (currentLebewesen is Lebewesen)
                    {
                        Console.WriteLine("Mensch ist ein Lebewesen, weil Mensch von Lebewesen erbt");
                    }

                    

                }

                if (currentLebewesen is Mensch human) //mit casten 
                {
                    // Mensch mensch = (Mensch)currentLebewesen;
                    if (currentLebewesen is Lebewesen)
                    {
                        Console.WriteLine("Mensch ist ein Lebewesen, weil Mensch von Lebewesen erbt");
                    }



                }

                //Ist IDisposeable implementiert worden :-) 
                if (currentLebewesen is IDisposable)
                {
                    Console.WriteLine("Interface IDisposeable wurde implementiert");
                }

                #endregion
            }
        }
    }
}
