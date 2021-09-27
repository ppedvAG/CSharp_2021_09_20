using System;

namespace Übung_Solid4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class PDFDocument
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Content { get; set; }

        public void Print(string Path)
        {

        }
    }

    public class CRSDocument : PDFDocument
    {
        public void PrintCRS(string Path)
        {

        }
    }


}
