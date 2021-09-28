using System;

using System.Dynamic;

namespace DynamicObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic myObj = new ExpandoObject(); //dynamic + ExpandoObject

            //Ich kann meiner Instanz Properties / Variablen  hinzufügen
            myObj.Vorname = "Max";
            myObj.AchIchWillPause = true;
            myObj.Nachname = "Musterfrau";
            myObj.Datum = DateTime.Now;

            var i = 123; 
            
        }

        public class Person
        {
            public string Name { get; set; }
        }
    }
}
