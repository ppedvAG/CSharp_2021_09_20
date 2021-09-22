using System;
using System.Collections.Generic;
using System.Linq;

namespace M009_02_LinqLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Person> persons = new List<Person>()
            {
                new Person {Id=1, Age=37, Vorname="Kevin", Nachname="Winter"},
                new Person {Id=2, Age=29, Vorname="Hannes", Nachname="Preishuber"},
                new Person {Id=3, Age=19, Vorname="Scott", Nachname="Hunter"},

                new Person {Id=4, Age=21, Vorname="Scott", Nachname="Hanselmann"},
                new Person {Id=5, Age=45, Vorname="Daniel", Nachname="Roth"},
                new Person {Id=6, Age=50, Vorname="Bill", Nachname="Gates"},

                new Person {Id=7, Age=70, Vorname="Newton", Nachname="King"},
                new Person {Id=8, Age=40, Vorname="Andre", Nachname="R"},
                new Person {Id=9, Age=60, Vorname="Petra", Nachname="Musterfrau"},
            };

            #region 1:N & N:M - Beispiel 


            //Tabelle - Kontinente 
            // 1.) Id 
            // 2.) Name

            //Tabelle - Länder 
            // 1.) Id
            // 2.) KontintentId
            // 3.) Name

            #region 1:N
            //Tablle Kontinent
            /** Id**** | ****** Name ****/
            /*   1     |   Europa */
            /*   2     |   Asien */

            //Tabelle Länder
            /** ID     |   Kontinent Id    | Name */
            /*   1     |        1          | Deutschland
             *   2     |        2          | Indien
             *   3     |        2          | Thailand
             */
            #endregion

            #region N:M
            //Tabelle - Sprachen
            /** Id**** | ****** Sprachbezeichnung ****/
            /*   1     |   Englisch */
            /*   2     |   Deutsch */
            /*   3     |   Spanisch */
            /*   4     |   Indisch */
            /*   5     |   Pakistan */

            //Tabelle - LaenderSprachen  (Brückentabelle) 
            /*  Id |  LandId | SprachId | Prozent 
                 1 |     2   |   4      |   95
                 2 |     2   |   5      |    5
                 3 |     1   |   2      |   99
             */

            #endregion
            #endregion


            //LinqStatment -> kommt aus der Zeit von LinqToSql (O/R-Mapper) 
            //Linq Statement
            // where / orderby /Select werden als Schlüsselwörter behndelt 
            IList<Person> linqStatementResult = (from p in persons
                                                 where p.Age >= 40 && p.Age <= 50
                                                 orderby p.Nachname
                                                 select p).ToList();

            //Linq-Functions Where(....) / OrderBy (.....) 
            //LAMBDA - Expressions -> (s => s.Age >= 40 && s.Age <= 50)
            IList<Person> people = persons.Where(s => s.Age >= 40 && s.Age <= 50)
                                          .OrderBy(o => o.Nachname)
                                          .ToList();
            

            double altersdurschnitt = persons.Average(a => a.Age);

            double altersdurchnittAb40 = persons.Where(p => p.Age > 40)
                                                .Average(a => a.Age);

            double gesamtAlterAllerPersonen = persons.Sum(a => a.Age);



            Person firstElementOrDefault = persons.FirstOrDefault(); //Default bedeutet, wenn die Liste leer ist, dann gibt es ein default Objeklt zurück
            Person firstElement = persons.First(); //Hier muss ein Element in der Liste sein 

            Person lastElement = persons.Last();
            Person lastElementOrDefault = persons.LastOrDefault();

            Person selectedPerson = persons.Single(n => n.Id == 5);
            Person selectedPersonOrDefault = persons.SingleOrDefault(n => n.Id == 5);


            if (persons.Count != 0)
            {
                //First or Last könnte man aufrufen 
            }

            if (persons.Any())
            {
                //First or Last könnte man aufrufen 
            }


            //Gibt es eine Person die über 60 Jahre alt ist. 
            if (persons.Any(a=>a.Age > 60))
            {

            }


            #region Pagging wird auf der WebAPI Seite implementiert 

            int pagingNumber = 1; //Aktuell Seite 
            int pagingSize = 3; //Anzahl der Elemente, die auf einer Seite angezeigt werden

            IList<Person> ergebnisseSeite1 = persons.Skip((pagingNumber - 1) * pagingSize).Take(pagingSize).ToList();


            //Seite 2
            pagingNumber = 2;
            IList<Person> ergebnisSeite2 = persons.Skip((pagingNumber - 1) * pagingSize).Take(pagingSize).ToList();

            //Seite 3
            pagingNumber = 3;
            IList<Person> ergebnisSeite3 = persons.Skip((pagingNumber - 1) * pagingSize).Take(pagingSize).ToList();
            #endregion 
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public int Age { get; set; }

        public string Vorname { get; set; }
        public string Nachname { get; set; }
    }
}
