using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M006_02_ClassFieldsProperties
{
    public class ElectroCar
    {
        private string _marke; //Field 

        private string _modell;


        //Property werden groß geschrieben und können (get/set/init) 
        public string Marke
        {
            get
            {
                return _marke;
            }

            // Marke = "BMW"; 
            //Setter mit Validierung
            set
            {
                //value ist ein resviertes Wort im Set-Block 
                //value repräsentiert den zugewiesen Wert

                if (value == string.Empty)
                    throw new ArgumentException("ElectroCar.Marke Set-Property kann keine leeren Strings zuweisen");
                
                //Andere Prüfung für null-Strings oder String.Empty oder nur Leerzeichen 
                if (string.IsNullOrWhiteSpace(value))
                {

                }

                _marke = value;
            }
        }

        //Property ohne Validierung, aber mit bezug auf ein Field-Feld
        public string Modell
        {
            get => _modell; //verkürzte Schreibweise zu get {return _modell}

            //get
            //{
            //    return _modell
            //}

            set => _modell = value; //Hier verzichten wird auf valdierung, wenn Validierung nötig, baue einfach das set aus -> set {_modell = value; }
        }

        public void StarteMotor()
        {
            // Starte den Motor
        }

        public void StoppeMotor()
        {
            //Stoppe den Motor 
        }
    }
}
