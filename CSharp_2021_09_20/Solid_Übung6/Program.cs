using System;

namespace Solid_Übung2
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public interface IPrinter
    {
        void Print(string printContent);
        void Scan(string ScanContent);
        void Fax(string FaxContent);

        void PrintDuplex(string PrintDuplexContent);

    }
    
    //AUFGABE -> Extrahiere aus den beiden Klassen ein gemeinsames Interface
    public class HPLaserJetPrinter : IPrinter
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine("Print Done");
        }
        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan content");
        }
        public void Fax(string FaxContent)
        {
            Console.WriteLine("Fax content");
        }
        public void PrintDuplex(string PrintDuplexContent)
        {
            Console.WriteLine("Print Duplex content");
        }
    }


    class LiquidInkjetPrinter : IPrinter
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine("Print Done");
        }
        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan content");
        }
        public void Fax(string FaxContent)
        {
            throw new NotImplementedException();
        }
        public void PrintDuplex(string PrintDuplexContent)
        {
            throw new NotImplementedException();
        }
    }
}
