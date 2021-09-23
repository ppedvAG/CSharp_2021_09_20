using System;

namespace M008_02_Fuhrpark
{
    class Program
    {
        static void Main(string[] args)
        {
            ElectroPKW electroPKW = new ElectroPKW(2021, "Tesla", 50, "grau", 4, 4);
            ElectroPKW electroPKW1 = new ElectroPKW(2021, "Tesla", 50, "grau", 4, 4);
            ElectroPKW electroPKW2 = new ElectroPKW(2021, "Tesla", 50, "grau", 4, 4);

            BenzinPKW benzinPKW = new BenzinPKW(2021, "VW", 250, "rot", 4, 4);
            BenzinPKW benzinPKW1 = new BenzinPKW(2021, "Ferarrie", 350, "rot", 4, 4);
            BenzinPKW benzinPKW2 = new BenzinPKW(2021, "Porsche", 350, "schwarz", 4, 4);


            MotorBoot motorBoot = new MotorBoot(2021, "Blub Blub Blub GmbH", 10, "blau", 1);
            MotorBoot motorBoot1 = new MotorBoot(1899, "Blub Blub Blub GmbH", 10, "blau", 1);
            MotorBoot motorBoot2 = new MotorBoot(1905, "Blub Blub Blub GmbH", 10, "blau", 1);
            Segelschiff segelschiff = new Segelschiff(1789, "Barbosa AG", 12, "schwarz", 0.5, 3, 50);

            Ruderboot ruderboot = new Ruderboot(1910, "Romantic Ship GmbH", 12, "grün", 1, 1);


            Garage garage = new Garage(15);
            garage.ParkeFahrzeugInGarage(electroPKW);
            garage.ParkeFahrzeugInGarage(benzinPKW);
            garage.ParkeFahrzeugInGarage(benzinPKW1);
            garage.ParkeFahrzeugInGarage(benzinPKW2);
            garage.ParkeFahrzeugInGarage(motorBoot);
            garage.ParkeFahrzeugInGarage(segelschiff);
            garage.ParkeFahrzeugInGarage(ruderboot);



            Console.WriteLine("Inventarliste, meiner Vehicle(Car, Ship) + Statistik über Antriebe");
            garage.WelcheFahrzeugeSindInDerGarage();



            Console.WriteLine("Anzeige Anzahl der erstellten Fahrzeuge an: ");
            Console.WriteLine(Vehicle.ZeigeAnzahlFahrzeuge()); 

        }
    }
}
