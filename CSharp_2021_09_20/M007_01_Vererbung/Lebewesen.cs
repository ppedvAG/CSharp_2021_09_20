using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M007_01_Vererbung
{
    public class Lebewesen //Allgemeine Beschreibung 
    {
        private int Id { get; set; }
        //Was sind gemeinsamkeiten aller Lebenwesen
        public int Alter { get; set; }

        public void Atmen ()
        {
            Console.WriteLine("Lebewesen atmet");
        }

        public void Schlafen()
        {
            Console.WriteLine("Lebewese schläft");
        }

        public void Essen()
        {
            Console.WriteLine("Lebewese isst");
        }

        public Lebewesen() //Wäre eiegentlich die Geburt eines Lebewesen -> Alter auf eine Minute oder Sekunde setzen
        {
            Alter = 0;
        }

        public Lebewesen(int alter)
        {
            this.Alter = alter;
        }
    }

    public class Mensch : Lebewesen //Klasse Mensch erbt von Lebewesen 
    {
        //Die Klasse Mensch hat Zugriff auf alle Public - Properties + Methoden

        public string Wohnort { get; set; }

        public void Lesen()
        {

        }

        public bool Daumen { get => true; }

        public Mensch(int alter, string wohnort)
            :base(alter) //-> Aufruf -> Lebewesen(int alter) - Konstruktor
        {
            this.Wohnort = wohnort;
        }
    }

    public class Mitarbeiter : Mensch
    {
        public string Arbeitgeber { get; set; }
       
        public DateTime ArbeitszeitVon { get; set; }
        public DateTime ArbeitzeitBis { get; set; }
        public bool IsStaatlichKrankenversichert { get; set; }

        public int Urlaubstage { get; set; }


        public void Vertragsverhandlung()
        {
        }
        //Arbeitzeiten lasse ich jetzt mal aussen vor
        //(Grund -> DateTime mit Datumsbezug, ist keine allgemeine Aussage zu einer Allgemeinen Zeit)
        public Mitarbeiter(int alter, string wohnort, string arbeitgeber, bool isVersichtert, int urlaubstage)
            :base(alter, wohnort)
        {
            this.Arbeitgeber = arbeitgeber;
            this.IsStaatlichKrankenversichert = isVersichtert;
            this.Urlaubstage = urlaubstage;
        }
    }

    public class Freiberufler : Mensch
    {
        public string Auftraggeber { get; set; }

        public Freiberufler(int alter, string wohnort, string auftraggeber)
            :base(alter, wohnort)
        {
            this.Auftraggeber = auftraggeber;
        }

        public void Aquise()
        {
        }


        public void Abbrechnung()
        { 
        }
    }

}
