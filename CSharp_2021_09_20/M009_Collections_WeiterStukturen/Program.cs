using System;
using System.Collections;
using System.Collections.Generic;

namespace M009_Collections_WeiterStukturen
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Liste -> benötigt using System.Collections.Generic;

            //interhalb einer Liste wird ein String-Array mit 4 Felder verwendet. 
            List<string> namesListe = new List<string>();
            namesListe.Add("Hallo");
            namesListe.Add("Hello World");

            //Kopieren eine Liste in eine andere Liste
            List<string> destinationList = new List<string>();
            destinationList.AddRange(namesListe.ToArray());


            //überprüfen, ob Eintrag schon in der Liste sind, wenn nicht, wird dieser hinzugefügt
            if (!namesListe.Contains("Harry"))
                namesListe.Add("Harry");



            IList<string> myNameList = new List<string>();
            #endregion

            #region Dictionary
            Dictionary<int, string> einwohnerRegister = new Dictionary<int, string>();
            einwohnerRegister.Add(1, "Andre Ruhland");
            einwohnerRegister.Add(2, "Hannes Preishuber");
            einwohnerRegister.Add(3, "Daniel Roth");
            einwohnerRegister.Add(4, "Scott Hanselmann");
            einwohnerRegister.Add(5, "Newtonsoft King"); //<- ERROR -> doppelter Key

            //KeyValuePair<int, string> entryForDictionary = new KeyValuePair<int, string>(6, "Scott Hunter");
            //einwohnerRegister.Add(entryForDictionary);

            foreach(KeyValuePair<int, string> currentEntry in einwohnerRegister)
            {
                Console.WriteLine($"{currentEntry.Key} - {currentEntry.Value}");
            }

            if (!einwohnerRegister.ContainsKey(7))
            {
                einwohnerRegister.Add(7, "Kevin Winter");
            }


            string sayMyName = einwohnerRegister[7];

            if (sayMyName == "Kevin Winter")
            {
                Console.Beep();
            }
            
            //For Schleife auf Dictionaries
            //for (int index = 0; index < einwohnerRegister.Count; index++)
            //    Console.WriteLine(einwohnerRegister[index]);
            #endregion

            #region  AntiBeispiel Hashtable
            //key / value -> like dictionary
            
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "Max Musterfrau");
            hashtable.Add("Max Muster", 1);
            hashtable.Add(new DateTime(), 49.99m);
            hashtable.Add(myNameList, einwohnerRegister);


            for (int index = 0; index < hashtable.Count; index++)
            {
               
            }

            foreach (object currentobject in hashtable)
            {
                //Wollen wir alle Datentypen durchprüfen?????? 
                if (currentobject is string)
                { 
                }

            }
            #endregion

            #region Stack

            //Der neuste Eintrag, wird zuerst ausgelesen 
            //Symbolisches Beispiel -> Der KArtenstapel (oberste Karte=neusteKarte) wird zuerst auch abgehoben.

            Stack<string> stringStack = new Stack<string>();

            stringStack.Push("Element 1");
            stringStack.Push("Element 2");
            stringStack.Push("Element 3"); // Letztes Element wird zuerst gelesen 

            foreach (string item in stringStack)
            {
                Console.WriteLine(item);
            }


            string element3 = stringStack.Pop(); //Element 3 wird ausgelesen und 'Element 3' wird vom Stack gelöscht

            //Elemnt 2 wird nur ausgelesen und nicht vom Stack gelöscht
            string elemnt2 = stringStack.Peek();
            #endregion //Symbolisches Beispiel -> Der Kartenstapel 

            #region Queue -> symbolisches Beispiel -> Wartezimmer bei Arzt
            Queue<string> stringQueue = new Queue<string>();

            stringQueue.Enqueue("Peter");
            stringQueue.Enqueue("Heike");
            stringQueue.Enqueue("Sarina");
            stringQueue.Enqueue("Adam");

            string peterWirdAusgelesen = stringQueue.Dequeue(); //ältester Eintrag wird ausgelesen und der Eintrag in Queue gelöscht

            string nurAuslesenOhneLöschen = stringQueue.Peek();  //ältester Eintrag wird ausgelesen und der Eintrag in Queue NICHT gelöscht
            #endregion


            //Tuple kommt aus der Programmiersprache Phyton
            #region Tuple 
            Movie movie = new Movie(1, "Star Wars", "Rückerkehr der .NET Programmierer", 9.99m);
            (string title, string beschreibung, decimal preis) = movie.GetTitleDescitpionAndPrice();

            Console.WriteLine(title);
            Console.WriteLine(beschreibung);
            Console.WriteLine(preis);

            #region weitere Varianten

            //Beispiel: die allgemeinste Form
            var name = movie.GetTitleDescitpionAndPrice();

            Console.WriteLine(name.Item1);
            Console.WriteLine(name.Item2);
            Console.WriteLine(name.Item3);

            //Alias werden via Methode festgelegt
            var ausgabe = movie.GetTitelAndBeschreibung();
            Console.WriteLine(ausgabe.titel);
            Console.WriteLine(ausgabe.beschreibung);
            #endregion


            #region Tuple elements with discards
            (string title1,_, decimal preis1) = movie.GetTitleDescitpionAndPrice();

            Console.WriteLine(title1);
            Console.WriteLine(preis1);
            #endregion

            #region Deconstruction - Beispiel

            var (myId, myTitle, myDescription, myPrice) = movie; // Wir rufen hier  public void Deconstruct(out int id, out string title, out string description, out decimal price)
            Console.WriteLine(myId);
            Console.WriteLine(myTitle);
            Console.WriteLine(myDescription);
            Console.WriteLine(myPrice);
            #endregion

            #endregion

            

        }
    }
}
