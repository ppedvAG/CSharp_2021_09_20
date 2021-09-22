using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M007_03_abstract
{
    public abstract class Shape
    {
        public abstract int GetArea();

        public virtual double Radiusbeerechnung()
        {
            return Math.PI;
        }
    }

    public class Square : Shape
    {
        int side;

        public Square(int n)
        {
            side = n;
        }

        // GetArea method is required to avoid a compile-time error.
        public override int GetArea()
        {
            return side * side;
        }
    }

    public class Circle : Shape
    {
        public override int GetArea() // Diese Methode wird garantiert, dass wir eine Flächenberechnung haben -> abstract sei Dank!
        {
            return 1 + 2 + 3; //soezielle Formel like 1+2+3
        }


        public override double Radiusbeerechnung() //Optionale Überschreibungsmöglichkeit WENN Radiusberechnung bei einem Kreis sinnvoll ist.
        {
            return 1 + 2 + 3 + 4 + 5;
        }
    }

}
