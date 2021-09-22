using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M007_02_Virtual
{
    public class Lebewesen
    {
        public virtual int Alter { get; set; } //Hier wird ein Back-Field erstellt -> Ist eine Auto-Property
    }

    public class Mensch : Lebewesen
    {
        public string Wohnort 
        { 
            get; 
            set;
        }
    }

    public class Mitarbeiter : Mensch
    {
        private int alter;

        //Mitarbeiter dürfen erst ab 16 Jahren arbeiten 
        public override int Alter 
        { 
            get => alter; 
            set
            {
                if (value < 16)
                    throw new Exception("Mitarbeiter müssen mindestens 16 Jahre alt sein");


                alter = value;
            }
        }
    }


    public class Freiberufler : Mensch
    {
        private int alter;
        //Freiberufler dürfen erst ab 18 Jahren ein Gewerbe anmelden 
        public override int Alter
        {
            get => alter;
            set
            {
                if (value < 18)
                    throw new Exception("Mitarbeiter müssen mindestens 16 Jahre alt sein");

                alter = value;
            }
        }
    }

}
