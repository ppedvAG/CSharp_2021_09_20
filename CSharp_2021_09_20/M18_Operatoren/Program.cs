using System;

namespace M18_Operatoren
{
    class Program
    {
        static void Main(string[] args)
        {
            Bruch bruchA = new Bruch(1, 2);
            Bruch bruchB = new Bruch(1, 2);

            
            if (bruchA == bruchB) // Speicheradresse von bruchA und bruchB  
            {
                Console.WriteLine("Bruch ist gleich");
            }
            else
            {
                //Brüche sind ungleich 
            }

            if (bruchA.Zähler == bruchB.Zähler && bruchA.Nenner == bruchB.Nenner)
            {

            }



            
        }
    }

    public class Bruch
    {
        public int Zähler { get; set; }
        public int Nenner { get; set; }

        public Bruch(int zähler, int nenner)
        {
            this.Zähler = zähler;
            this.Nenner = nenner;
        }

        public static bool operator == (Bruch left, Bruch right)
        {
            if (left.Nenner != right.Nenner)
                return false;

            if (left.Zähler != right.Zähler)
                return false;


            return true; 
        }

        public static bool operator != (Bruch left, Bruch right)
        {
            if (left.Nenner == right.Nenner)
                return false;

            if (left.Zähler == right.Zähler)
                return false;


            return true;
        }

        public override bool Equals(object obj)
        {
            Bruch bruchToCheck = (Bruch)obj;

            if (this.Nenner != bruchToCheck.Nenner)
                return false;

            if (this.Zähler != bruchToCheck.Zähler)
                return false;

            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


        #region < + >

        public static bool operator >(Bruch left, Bruch right)
        {
            //.... 
            return true;
        }

        public static bool operator <(Bruch left, Bruch right)
        {
            return true;
        }
        #endregion

        #region <=  +  >=
        public static bool operator >=(Bruch left, Bruch right)
        {
            return true;
        }
        public static bool operator <=(Bruch left, Bruch right)
        {
            return true;
        }
        #endregion

        public static Bruch operator *(Bruch left, Bruch right)
           => new Bruch(left.Zähler * right.Zähler, left.Nenner * right.Nenner);

        //Operatoren können auch überladen werden :-) 
        public static Bruch operator *(Bruch left, int zähler)
        {
            return new Bruch(left.Zähler * zähler, left.Nenner);
        }

    }
}
