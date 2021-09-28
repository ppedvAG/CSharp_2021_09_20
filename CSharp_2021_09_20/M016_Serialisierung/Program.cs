using System;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace M016_Serialisierung
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                Vorname = "Max",
                Nachname = "Muster",
                Alter = 45,
                Kontostand = 1_000_000, // int
                KreditLimit = 5_000_000
            };
            
            Person person2 = new Person()
            {
                Vorname = "Maria",
                Nachname = "Muster",
                Alter = 33,
                Kontostand = 10_000_000,
                KreditLimit = 50_000_000
            };


            // BinarySample();
            // XmlSerialisierung


            person.Serialize("Person.csv");

            Person newPerson = new Person();
            newPerson.Deserialize("Person.csv");

            

        }


        public static void BinarySample()
        {
            Person person = new Person()
            {
                Vorname = "Max",
                Nachname = "Muster",
                Alter = 45,
                Kontostand = 1_000_000, // int
                KreditLimit = 5_000_000
            };

            Stream stream = null;

            #region Binäre Serialisierung

            //Schreiben
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            stream = File.OpenWrite("Person.bin");
            binaryFormatter.Serialize(stream, person);

            //Wenn es zu Problemen kommen könnte  
            //stream.Flush(); //Schreibe den komplett Buffer raus.... 
            stream.Close();

            //Lesen
            stream = File.OpenRead("Person.bin");
            Person geladenePerson = (Person)binaryFormatter.Deserialize(stream);
            stream.Close();
            #endregion
        }


        public static void XmlSerialisierung()
        {
            Person person = new Person()
            {
                Vorname = "Max",
                Nachname = "Muster",
                Alter = 45,
                Kontostand = 1_000_000, // int
                KreditLimit = 5_000_000
            };


            #region Xml Serialisierung
            Stream stream = null;




            //schreiben 
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));

            if (File.Exists("Person.xml"))
                File.Delete("Person.xml");

            stream = File.OpenWrite("Person.xml");
            xmlSerializer.Serialize(stream, person);
            stream.Close();

            //lesen 
            stream = File.OpenRead("Person.xml");
            Person geladenePersonAusXMLDatei = (Person)xmlSerializer.Deserialize(stream);
            stream.Close();
            #endregion
        }

        public static void JsonSample()
        {
            Person person = new Person()
            {
                Vorname = "Max",
                Nachname = "Muster",
                Alter = 45,
                Kontostand = 1_000_000, // int
                KreditLimit = 5_000_000
            };
            #region JSON 

            //Schreiben
            string jsonString = JsonConvert.SerializeObject(person);
            File.WriteAllText("Person.json", jsonString);

            //Lesen
            string readJsonString = File.ReadAllText("Person.json");

            //JObject obj = (JObject)JsonConvert.DeserializeObject(readJsonString);
            //foreach (var current in obj.Root)
            //{

            //}

            Person geleadenePerosn1 = JsonConvert.DeserializeObject<Person>(readJsonString);



            #endregion
        }
    }

    /*[Serializable]*/ //Markiert dass diese Klasse binär weggeschrieben werden darf

    [Serializable]
    public class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public int Alter { get; set; }
        
        //Properties ausblenden
        //[field: NonSerialized] //-> für Binär
        //[XmlIgnore] -> für Xml 
        //[JsonIgnore]
        
        public decimal Kontostand { get; set; }


        //Variablen ausblenden
        //[NonSerialized]// -> für Binär + Newtonsoft.JSON
        //[XmlIgnore] -> für Xml 
        //[JsonIgnore]
        public decimal KreditLimit;
    }


    public static class CSVSerializer //Erweiterungsmethoden liegen in einer static class
    {
        //Serialize soll bei Person angehängt werden 
        public static void Serialize(this Person p, string path)
        {
            File.WriteAllText(path, $"{p.Vorname};{p.Nachname};{p.Alter};{p.Kontostand};{p.KreditLimit}");
        }

        public static void Deserialize(this Person p, string path)
        {
            string content = File.ReadAllText(path);


            //Kevin;Winter;38;1000000;2000000

            //[0] = Kevin
            //[1] = Winter
            //[2] = 38
            //[3] = 1000000
            //[4] = 2000000
            string[] csvParts = content.Split(';');

            p.Vorname = csvParts[0];
            p.Nachname = csvParts[1];
            p.Alter = Convert.ToInt32(csvParts[2]);
            p.Kontostand = Convert.ToInt32(csvParts[3]);
            p.KreditLimit = Convert.ToInt32(csvParts[4]);
        }
    }



    
}
