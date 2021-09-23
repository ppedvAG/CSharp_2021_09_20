using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M008_02_Fuhrpark
{
    public class KraftwagenBase :Vehicle
    {

        //enum AntriebsTyp { Benzin, Elektro, ... }
        public KraftwagenBase(int baujahr, string marke, double maxGeschwindigkeit, string farbe, int raederAnzahl, int türAnzahl) 
            : base(baujahr, marke, maxGeschwindigkeit, farbe)
        {
            Räderanzahl = raederAnzahl;
            Türenanzahl = türAnzahl;
        }

        public int Räderanzahl { get; set; }
        public int Türenanzahl { get; set; }


       
    }


    public class ElectroPKW : KraftwagenBase, IElectroMotor
    {
        public ElectroPKW(int baujahr, string marke, double maxGeschwindigkeit, string farbe, int raederAnzahl, int türAnzahl) 
            : base(baujahr, marke, maxGeschwindigkeit, farbe, raederAnzahl, türAnzahl)
        {
        }

        public int AkkuLaufzeut { get; set; }
        public int ReichweiteMitEinerTankfüllung { get; set; }
        public int PS { get; set; }
    }


    public class BenzinPKW : KraftwagenBase, IBenzinMotor
    {
        public BenzinPKW(int baujahr, string marke, double maxGeschwindigkeit, string farbe, int raederAnzahl, int türAnzahl) : base(baujahr, marke, maxGeschwindigkeit, farbe, raederAnzahl, türAnzahl)
        {
        }

        public OctavenTypen BenzinTyp { get; set; }
        public int ReichweiteMitEinerTankfüllung { get; set; }
        public int PS { get; set; }
    }

    
}
