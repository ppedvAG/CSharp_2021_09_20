using System;

namespace M004_02_Enums
{
    enum Wochentag { Mo, Di, Mi, Do, Fr, Sa, So}

    enum MyPCItems { Monitor=5, PC, Tastatur, WebCam, Maus }

    enum AnredeFormen {  Herr, Frau, Dr, Prof, Dipl, Magister}


    [Flags] //Bitfelder 
    enum Fruechte 
    { 
        Keines = 0,
        Orange = 1,
        Kirsche = 2,
        Banane = 4,
        Apfel = 8,
        Pflaume = 16,
        Birne = 32
    }

    class Program
    {
        static void Main(string[] args)
        {

            #region Enum Vs Array -> puncto Lesbarkeit nach ein paar Wochen
            string[] wochentageArray = new string[] { "Montag", "Dienstag", "Mittwoch", "Donnerstag", "Freitag", "Samstag", "Sonntag" };

            string dayofWeek = wochentageArray[0]; //Welcher Index, ist welcher Tag. 

            Wochentag dayofWeekEnum = Wochentag.Mi;

            if (wochentageArray[0] == "Montag")
            {

            }
            if (dayofWeekEnum == Wochentag.Mi)
            {

            }


            string[] genderForm = new string[] { "Male", "Female", "Others" };
            string[] anredeFormArray = new string[] { "Frau", "Herr", "Dr", "Prof" };
            
            AnredeFormen anredeFormenEnum = AnredeFormen.Magister;

            if (anredeFormenEnum == AnredeFormen.Magister)
            {

            }
            #endregion

            #region Einstieg in Enums

            #region Einfaches Beispiel
            Wochentag myWeekEnum = Wochentag.Fr;
            if (myWeekEnum == Wochentag.Mi)
            {
            }

            //Enums vom selben Typ, kann man auch prüfen 
            if (myWeekEnum == dayofWeekEnum)
            {
            }
            #endregion

            #region Enum konventieren zu einer Zahl
            //wert 4 wird ausgelesen und kann gegenüber einer DB gespeichert werden 
            int selectedValue = (int)myWeekEnum;


            //beim Laden von selectedValue aus der DB, kann man so wieder herum ein Enum initiazieren 
            Wochentag myDay = (Wochentag)selectedValue; //myDay wird auf Freitag gesetzt; 
            #endregion

            #region Enum mit definierten Index
            MyPCItems myPCItem = MyPCItems.Monitor;
            selectedValue = (int)myPCItem;
            Console.WriteLine($"Selected Value soll den Wert 5 enthalten - Ausgabe SelectedValue {selectedValue}");
            #endregion



            #endregion

            #region BitFelder Kombination
            //https://docs.microsoft.com/de-de/dotnet/api/system.flagsattribute?view=net-5.0
            Fruechte fruchtkorp = Fruechte.Orange | Fruechte.Banane | Fruechte.Birne;
            
            // 37 
            int value = (int)fruchtkorp;

            // 37 wird aus DB ausgelesen 


            //https://docs.microsoft.com/de-de/dotnet/api/system.enum.hasflag?view=net-5.0 ->google: enums with flags ODER enum bitflags
            bool IsOrangeImFruchtkopr = fruchtkorp.HasFlag(Fruechte.Orange);

            
            #endregion

            //BitFelder - Schleifen-Methode
        }
    }
}
