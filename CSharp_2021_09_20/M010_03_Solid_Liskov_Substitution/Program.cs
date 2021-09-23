using System;

namespace M010_03_Solid_Liskov_Substitution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    #region AntiBeispiel -> so niemals vererben
    public class Apfel
    {
        public virtual string GetColor()
        {
            return "Red";
        }
    }

    public class Organge : Apfel
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }


    #endregion


    #region Good Code
    public abstract class Fruit
    {
        public abstract string GetColor();
    }

    public class Apple : Fruit
    {
        public override string GetColor()
        {
            return "Red";
        }
    }

    public class Orange : Fruit
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }

    #endregion
}
