using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M007_02_Virtual
{
    public class Shape
    {
        //Beispiel -> private int x, y; //Innerhalb von shape akzeptiert

        //Beispiel -> public int // von überall

        // Beispiel -> protected -> //Innerhalb meines Verbten Baums

        protected double x, y; //Ist verfügbar in meinem vererbten Baum 

        public Shape(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual double GetArea ()
        {
            return x * y;
        }
    }


    public class Rectangle : Shape
    {
        public Rectangle(int x, int y)
            :base(x, y)
        {

        }


        //Rectange benötigt keine Überschreibung, weil die Basis-Implementierung ausreicht! 

        //Wenn ein Rectangle.GetArea aufgerufen -> wird Shape.GetArea ausgeführt. 
    }

    public class Quatrat : Shape
    {
        public Quatrat(int seitelaenge)
            :base(seitelaenge, seitelaenge)
        {
        }

        //Wenn ein Quatrat.GetArea aufgerufen -> wird Shape.GetArea ausgeführt. 

        public override double GetArea()
        {
            return base.GetArea(); //-> wird Shape.GetArea ausgeführt. 

            //!!!!Wir hätten die Option, diese Berechnung etwas zu erweitern -> Die Frage, ist eher, ob das nötig wäre
            //BEISPIEL-> double result = base.GetArea();
        }
    }

    public class Circle : Shape
    {
        public Circle(double radius)
            :base(radius,0)
        {
        }

        public override double GetArea()
        {
            return Math.PI * x * x;
        }
    }

    public class Sphere : Shape
    {
        public Sphere(double r) : base(r, 0)
        {
        }

        public override double GetArea()
        {
             return 4 * Math.PI * x * x;
        }
    }

    public class Cylinder : Shape
    {
        public Cylinder(double r, double h) : base(r, h)
        {
        }

        public override double GetArea()
        {
            return 2 * Math.PI * x * x + 2 * Math.PI * x * y;
        }


        public void Output()
        {
            // Ausgabe von Variablen
        }
    }



}
