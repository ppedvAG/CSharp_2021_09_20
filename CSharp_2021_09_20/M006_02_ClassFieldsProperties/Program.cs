using System;

namespace M006_02_ClassFieldsProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alte Variante 
            Oldtimer oldtimer = new Oldtimer();

            //Standard Variante via Properties 
            ElectroCar electroCar = new ElectroCar();






            BobbyCar2 bobbyCar2 = new BobbyCar2();


            //hier wirde keine Instanz hinterlegt -> es wird eine null zurück geliefert. 
            BobbyCar bobbyCar = bobbyCar2.BobbyCar;
        }
    }
}
