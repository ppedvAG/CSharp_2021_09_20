using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M007_03_abstract
{
    public abstract class BaseClass //Schablone -> Bedeutet, BaseClass kann nicht instanziiert werden
    {
        protected int _z = 99;
        protected int _x = 100;
        protected int _y = 150;

        public abstract int X { get; }
        public abstract int Y { get; }

        public abstract int Z { get; set; }

        public abstract void AbstractMethode(); ///Diese Methode muss in jeder abgeleiteten Klassen überschrieben weden
    }

    public class DerivedClass : BaseClass
    {
        public override int X
        {
            get
            {
                return _x;
            }
        }

        public override int Y => _y;

        public override int Z
        {
            get => _z;
            set => _z = value;
        }

        
        public override void AbstractMethode()
        {
            //Müssen wir ausimplementierung
        }
    }


}
