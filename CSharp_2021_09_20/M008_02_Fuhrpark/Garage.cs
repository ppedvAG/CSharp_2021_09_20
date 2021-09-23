using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M008_02_Fuhrpark
{
    public class Garage
    {
        private List<Vehicle> fahrzeugListe = new List<Vehicle>();
        public int MaxParkplaetze { get; set; } = 10; //DEfault-Wert


        public Garage()
        {

        }

        public Garage(int parkplätze)
        {
            MaxParkplaetze = parkplätze;
        }

        public List<Vehicle> FahrzeugListe { get => fahrzeugListe; set => fahrzeugListe = value; }

        public void ParkeFahrzeugInGarage(Vehicle fahrzeug)
        {
            if (MaxParkplaetze > FahrzeugListe.Count)
                FahrzeugListe.Add(fahrzeug);
        }

        public void WelcheFahrzeugeSindInDerGarage()
        {
            int electroPKWCounter = 0;
            int benzinPKWCounter = 0;

            
            int segelSchiffCounter = 0;
            int ruderSchiffCounter = 0;
            int motorSchiffCounter = 0;

            int vehicleMitElectroAntrieb = 0;
            int vehicleMitBenzinAntrieb = 0;


            foreach (Vehicle currentFahrzeug in FahrzeugListe)
            {

                if (currentFahrzeug is BenzinPKW)
                {
                    if (currentFahrzeug.Marke == "Ferrarie")
                    {
                        //...
                        //Ferrarie muss nach Italien zur Repatur 
                    }
                    benzinPKWCounter++;
                }
                else if (currentFahrzeug is ElectroPKW)
                {
                    electroPKWCounter++;
                }
                else if (currentFahrzeug is Segelschiff)
                {
                    segelSchiffCounter++;
                }
                else if (currentFahrzeug is Ruderboot)
                {
                    ruderSchiffCounter++;
                }
                else if (currentFahrzeug is MotorBoot)
                {
                    motorSchiffCounter++;
                }

                if (currentFahrzeug is IElectroMotor)
                {
                    vehicleMitElectroAntrieb++;
                }
                else if (currentFahrzeug is IBenzinMotor)
                {
                    vehicleMitBenzinAntrieb++;
                }

            }

            Console.WriteLine($"---- Garageninventar ---- ");
            Console.WriteLine($"Elektro PKW-Anzahl:\t\t{electroPKWCounter} ");
            Console.WriteLine($"Benzin PKW-Anzahl:\t\t{benzinPKWCounter} ");
            Console.WriteLine($"SegelSchiff-Anzahl: \t\t{segelSchiffCounter}");
            Console.WriteLine($"RuderBoot-Anzahl: \t\t{ruderSchiffCounter}");
            Console.WriteLine($"MototBoot-Anzahl: \t\t{motorSchiffCounter}");


            // Antrieb-ÜBersicht
            Console.WriteLine($"ElektroAntriebe: \t\t{vehicleMitElectroAntrieb}");
            Console.WriteLine($"BenzinAntriebel: \t\t{vehicleMitBenzinAntrieb}");

        }
    }
}
