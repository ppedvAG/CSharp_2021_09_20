using System;
using System.Collections;
using System.Collections.Generic;

namespace M15_01_HelloGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> namenListe = new List<string>();
            namenListe.Add("Hello");

            DataStore<string, int> dataStore = new DataStore<string, int>();
            dataStore.AddOrUpdate(0, "Otto Walkes");
            dataStore.AddOrUpdate(1, "Jürgen von der Lippe");
            dataStore.AddOrUpdate(2, "Badesalz");


            DataStore<string, int>.DisplayDefault<DateTime>();
        }
    }

    public class DataStore<T, ABC>
    {
        private T[] _data = new T[10]; //private string[] _data new string[10];

        private ABC myABCDataType;


        public T[] Data
        {
            get => _data;
            set => _data = value;
        }

        public void AddOrUpdate(int index, T item)
        {
            if (index >= 0 && index < 10)
                _data[index] = item;
        }

        public T GetData(int index)
        {
            if (index >= 0 && index < 10)
                return _data[index];
            else
                return default(T);
        }


        public static void DisplayDefault<MyType>()
        {
            MyType item = default(MyType);

            Console.WriteLine($"Default value of {typeof(MyType)} is {(item == null ? "null" : item.ToString())}.");
        }
    }
}
