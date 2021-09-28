using System;

namespace Wiederholung_OOP_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public interface IFSK18Check
    {
        public bool Check(int age);
    }


    public interface IWLAN
    {

    }

    


    public class Jahrmarktstand
    {
        public int Miete { get; set; }
        public int Flaeche { get; set; }

        public DateTime ÖffnungszeitenVon { get; set; }
        public DateTime ÖffnungszeitenBis { get; set; }
    }

    public class MirrorCabinett : Jahrmarktstand, IWLAN
    {
        public int LabyrinthVarianten { get; set; }
    }

    public class HorrorCabinet : Jahrmarktstand, IFSK18Check
    {
        public int AnzahlDerSchauspieler { get; set; }

        public bool Check(int age)
        {
            throw new NotImplementedException();
        }
    }


    public class GetränkestandErwachsene : Jahrmarktstand, IFSK18Check
    {
        public bool Check(int age)
        {
            throw new NotImplementedException();
        }
    }






    #region Variante 1 

    public class JahresmarktBahnBase : Jahrmarktstand
    {
        public int Streckenlaenge { get; set; }
        public int Hoehe { get; set; }
        public int AnzahlDerWagen { get; set; }

        public int SpeedAverage { get; set; }
    }
    #endregion 




    public class Wildwasserbahn : JahresmarktBahnBase
    {
        
    }

    public class SchnellsteAchterbahnDerWelt : JahresmarktBahnBase, IFSK18Check
    {
        

        public bool Check(int age)
        {
            throw new NotImplementedException();
        }
    }

}


