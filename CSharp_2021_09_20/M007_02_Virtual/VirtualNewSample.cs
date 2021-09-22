using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M007_02_Virtual
{
    public class Fahrzeug
    {
        public virtual string WasBinIch()
        {
            return "Ich bin ein Fahrzeug";
        }
    }

    public class Auto : Fahrzeug
    {
        public new string WasBinIch() //<-- ich bin nur noch eine normale public - Methode
        {
            return "Ich bin ein Auto";
        }
    }

    public class ElectroCar : Auto
    {
        //Compiler Error CS0506
        //https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0506?f1url=%3FappId%3Droslyn%26k%3Dk(CS0506)
        //public override string WasBinIch() 
        //{
        //    return "Ich bin ein Elektroauto"; 
        //}
    }

}
