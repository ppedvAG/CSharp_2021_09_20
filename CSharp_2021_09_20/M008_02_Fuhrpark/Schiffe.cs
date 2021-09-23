using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M008_02_Fuhrpark
{
    public class ShipBase : Vehicle
    {
        public ShipBase(int baujahr, string marke, double maxGeschwindigkeit, string farbe, double tiefgang) 
            : base(baujahr, marke, maxGeschwindigkeit, farbe)
        {
            this.Tiefgang = tiefgang;
        }

        public double Tiefgang { get; set; }
    }

    public class Segelschiff : ShipBase, IWindAntrieb
    {
        public Segelschiff(int baujahr, string marke, double maxGeschwindigkeit, string farbe, double tiefgang, int mastanzahl, int segelfläche) 
            : base(baujahr, marke, maxGeschwindigkeit, farbe, tiefgang)
        {
            this.Mastanzahl = mastanzahl;
            this.InsegesamteSegelFläche = segelfläche;
        }
        public int Mastanzahl { get; set; }
        public int InsegesamteSegelFläche { get; set; }
    }

    public class Ruderboot : ShipBase, IMuskelkraftAntrieb
    {
        public Ruderboot(int baujahr, string marke, double maxGeschwindigkeit, string farbe, double tiefgang, int anzahlRuderer) 
            : base(baujahr, marke, maxGeschwindigkeit, farbe, tiefgang)
        {
            this.AnzahlRuderer = anzahlRuderer;
        }

        public int AnzahlRuderer { get; set; }
    }



    public class MotorBoot : ShipBase, IBenzinMotor
    {


        public MotorBoot(int baujahr, string marke, double maxGeschwindigkeit, string farbe, double tiefgang) 
            : base(baujahr, marke, maxGeschwindigkeit, farbe, tiefgang)
        {
        }

        public OctavenTypen BenzinTyp { get; set; }
        public int ReichweiteMitEinerTankfüllung { get; set; }
        public int PS { get; set; }
    }
}
