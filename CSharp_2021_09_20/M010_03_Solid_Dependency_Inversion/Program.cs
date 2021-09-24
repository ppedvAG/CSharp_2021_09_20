using System;

namespace M010_03_Solid_Dependency_Inversion
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarService carService = new CarService();

            //Wir können an Tag 3/4 vorab mit Mock-Objekten die MEthode RepairCar testen (Validierung, Workflows im Gesamten) 
            carService.RepairCar(new MockCar());

            //Das echte austesten der Implementierung kann erst an Tag 5/6
            carService.RepairCar(new Car());
            carService.RepairCar(new ElectroCar());
        }
    }

    #region BadCode
    //Programmierer A: 5 Tage Arbeitszeit für BadCar-Klasse
    public class BadCar //AutoObject
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int PS { get; set; }

        public int AnzahlTüren { get; set; }
    }

    //Wir können nur noch einfaches Veerben umsetzen 
    public class BadElectroCar : BadCar
    {
        
    }

    //Programmierer B: 3 Tage Arbeitszeit für BadCarService-Klasse

    //Muss jetzt wirklich Programmierer B 5 Tage warten? -> Insgesamt werden 8 Tage für das Projekt verwendet 
    public class BadCarService //Werkstatt
    {
       
        public void RepairCar(BadCar car) //Harte Verdrahtung -> Monolithen 
        {
            //Repariere Auto 
        }
    }
    #endregion


    #region GoodCode

    public interface ICar
    {
        int Id { get; set; }
        string Brand { get; set; }
        string Model { get; set; }
    }

    public interface ICarService
    {
        // ICar als Parameter bedeutet -> Alle Objekte, die ICar-Implementiert haben, können hier reingesetzt werden 
        void RepairCar(ICar car);
    }




    //Programmierer A benötigt weiterhin 5 Tage

    public class MockCar : ICar
    {
        public int Id { get; set; } = 2;
        public string Brand { get; set; } = "VW";
        public string Model { get; set; } = "Polo";
    }

    //public class MockElectorCar 

    public class Car : ICar
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
    }

    public class ElectroCar : Car
    {
        // Ist hier ok. 
    }


    //Programmierer B benötigt weiterhin 3 Tage. Kann aber an Tag 1 die Arbeit aufnehmen

    public class CarService : ICarService
    {
        public void RepairCar(ICar car)
        {
            //Repariere ein Auto

            
        }
    }


    //Nur zum Testen von Funktionen die auf ein ICar basieren -> kann man folgendes noch anstellen 

    

    #endregion
}
