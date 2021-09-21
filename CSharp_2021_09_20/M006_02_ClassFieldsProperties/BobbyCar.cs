using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M006_02_ClassFieldsProperties
{
    public class BobbyCar
    {
        //Auto - Properties -> genrieren zur Laufzeit ihre eigene Field - Variable 
        public string Marke { get; set; }
        public string Modell { get; set; }
    }


    public class BobbyCar2
    {
        private string _marke;
        
        //Auto - Properties -> Marke benötigt Validierung -> wie komme ich an ein value-Keyword? 
        public string Marke 
        { 
            get
            {
                return _marke;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _marke = value;

            }
        }
        public string Modell { get; set; }


        //komlexe Objekte funktionieren
        public BobbyCar BobbyCar { get; set; }
    }
}
