using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M006_03_Object_Konstruktor_MakeInstance
{
    public class Car //Klasse ohne Konstruktor -> Warum kann ich trotzdem einen Konstruktor aufrufen? 
    {
        //public Car() -> wird quasi vom Kompilier hinzugefügt
        //{

        //}
        public string Brand { get; set; } 
        public string Model { get; set; }
        public int ConstructionYear { get; set; }
    }

    public class Car2 //Klass mit einem Konstruktor 
    {
        private string _brand;
        public string Brand 
        {
            get => _brand;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException();

                _brand = value;
            }
        } 
        public string Model { get; set; }
        public int? ConstructionYear { get; set; }

        public int[] ZahlenArray { get; set; }

        //ctor + tab + tab
        public Car2() //Default-Konstruktor -> Stellt einen Default-Stand für ein Object 
        {
            Brand = default(string); //string.Emptiy
            Model = default(string);
            ConstructionYear = null; //Wert '0' wird zugewiesen 

            //Default Zuweisung eines Array
            ZahlenArray = Array.Empty<int>();
        }

        //Ein Werte-Konstruktor kann aus vielen Variablen ein Objekt befüllen. 
        //Die Fields werden mithilfe deren Properties befüllt. Eine direkt Zuweisung soll nicht verwendet werden, weil eventuell Validierungs-Logik nicht verwendet wird.
        public Car2(string brand, string model, int year, int[] initArray)
        {
            Brand = brand; //Brand->Setter = brand
            Model = model;
            ConstructionYear = year;

            ZahlenArray = initArray;
        }
    }
}
