using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M008_02_Fuhrpark
{
    public class Vehicle
    {
        private int baujahr;
        private string marke;
        private double aktGeschwindigkeit;
        private double maxGeschwindigkeit;

        private string farbe;


        public Vehicle()
        {
            aktGeschwindigkeit = 0;
            AnzahlErstellterVehicles++; //static Variablen kann man via Konstruktor aufrufen 

        }
        public Vehicle(int baujahr, string marke, double maxGeschwindigkeit, string farbe)
            : this()
        {
            Baujahr = baujahr;
            Marke = marke;
            MaxGeschwindigkeit = maxGeschwindigkeit;
            Farbe = farbe;
        }

        public int Baujahr { get => baujahr; set => baujahr = value; }
        public string Marke { get => marke; set => marke = value; }
        public double AktGeschwindigkeit { get => aktGeschwindigkeit; set => aktGeschwindigkeit = value; }
        public double MaxGeschwindigkeit { get => maxGeschwindigkeit; set => maxGeschwindigkeit = value; }
        public string Farbe { get => farbe; set => farbe = value; }

        #region Methoden
        
        //Starte Motor
        //Stoppe Motor 

        public void Beschleunigung(int offsetGeschwindigkeit)
        {
            if (this.AktGeschwindigkeit + offsetGeschwindigkeit > maxGeschwindigkeit)
            {
                this.AktGeschwindigkeit = MaxGeschwindigkeit;
            }
            else if (this.AktGeschwindigkeit + offsetGeschwindigkeit < 0)
            {
                this.AktGeschwindigkeit = 0;
            }
        }

        public void Bremsen()
        {
            if (aktGeschwindigkeit - 5 < 0)
                aktGeschwindigkeit = 0;

            aktGeschwindigkeit -= -5;
        }
        #endregion


        #region static 

        public static int AnzahlErstellterVehicles { get; private set; }
        public static string ZeigeAnzahlFahrzeuge()
        {
            return $"Es wurden {AnzahlErstellterVehicles} Vehicle-Objekte erstellt";
        }
        public static double MphToKmh(double mph)
        {
            //static-methode kann auch static methode aufrufen -> siehe  ->KmhToMph(100);

            return mph * 1.60934;
        }

        public static double KmhToMph(double kmh)
        {
            return 0.6214 * kmh;
        }

        #endregion

    }
}
