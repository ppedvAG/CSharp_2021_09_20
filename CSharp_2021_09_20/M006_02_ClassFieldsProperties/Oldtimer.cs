using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M006_02_ClassFieldsProperties
{
    public class Oldtimer
    {
        //Field (Felder) ODER  Klassen-> Member-Variablen 
        private string _marke;
        //private string _modell; -> underliner+Fieldname -> stil kommt aus C++ -> m_modell -> m steht für Member

        #region Access Methoden für Fields
        //Befülle Membervariable _marke 
        public void SetMarke(string marke) //Via Set-MEthode wird die Zuweisung kontrollierbar und lenkbar
        {
            //Validierungsmöglichkeiten 
            if (marke == string.Empty)
                throw new ArgumentException("SetMarke -> benötigt einen befüllten Parameter");

            _marke = marke;
        }

        public string GetMarke()
        {
            return _marke;
        }
        #endregion

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
