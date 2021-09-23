using System;
using System.Collections.Generic;

namespace M008_01_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Beispiel 1 -> Klasse mit impliziter Interface-Implementierung
            DateTimeService dateTimeService = new DateTimeService();
            Console.WriteLine(dateTimeService.GetCurrentDateTime());
            #endregion

            #region Beispiel 2 -> Klasse mit expliziter Interface - Implementierung
            IDateTimeService dateTimeService2 = new DateTimeService2();
            dateTimeService.GetCurrentDateTime(); // IDateTimeService.GetCurrentDateTime();

            IWatchClockTimeService dateTimeService3 = new DateTimeService2();
            dateTimeService3.GetCurrentDateTime(); // IWatchClockTimeService.GetCurrentDateTime();
            #endregion

            IRepository repository = new PersonRepository();
            //Lese-Methoden
            repository.GetAll();
            repository.GetById(123);

            //Schreibmethoden
            repository.Insert(new Person());
            repository.Update(123, new Person());
            repository.Delete(123);


            IReadRepository readOnlyRepository = new PersonRepository();
            readOnlyRepository.GetAll();
            readOnlyRepository.GetById(123);


            List<string> namenListe = new List<string>();
            //Wir verwenden die komplette Implementierung der Klasse List<T> 


            IList<string> namenListeWithInterface = new List<string>();
            //IList interface bietet nur Methoden an, die für das manipulieren einer Liste verantwortlich sind

               

        }
    }

    #region Beispiel 1 & 2
    public interface IDateTimeService
    {
        public DateTime GetCurrentDateTime();
    }

    public interface IWatchClockTimeService
    {
        public DateTime GetCurrentDateTime();
    }

    //Meine Klasse mit einer Implizieten Interface Implementierung

    public class DateTimeService : IDateTimeService
    {
        //Wir müssen Interface, beim verwenden komplett ausimplementieren (-> C# 8.0 hat Ausnahmen mitgebracht) 
        public DateTime GetCurrentDateTime()
        {
            return DateTime.Now;
        }
    }

    public class DateTimeService2 : IDateTimeService, IWatchClockTimeService
    {
        DateTime IDateTimeService.GetCurrentDateTime()
        {
            return DateTime.Now;
        }

        DateTime IWatchClockTimeService.GetCurrentDateTime()
        {
            return DateTime.UtcNow;
        }
    }
    #endregion


    #region CRUD (Create, Read, Update, Delete) 
    public interface IReadRepository
    {
        IList<Person> GetAll();
        Person GetById(int Id);
    }

    public interface IRepository : IReadRepository
    {
        public void Insert(Person person);
        public void Update(int Id, Person modifiedPerson);
        public void Delete(int Id);
    }

    public class CarRepository
    {
        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IList<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        public Person GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Person person)
        {
            throw new NotImplementedException();
        }

        public void Update(int Id, Person modifiedPerson)
        {
            throw new NotImplementedException();
        }
    }
    public class PersonRepository : IRepository
    {
        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IList<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        public Person GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Person person)
        {
            throw new NotImplementedException();
        }

        public void Update(int Id, Person modifiedPerson)
        {
            throw new NotImplementedException();
        }
    }


    #endregion


    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
