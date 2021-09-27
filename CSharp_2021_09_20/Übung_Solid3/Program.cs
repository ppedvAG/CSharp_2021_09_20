using System;

namespace Übung_Solid5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    #region BadCode

    public class Document
    {
        public int Id { get; set; }
        public int Title { get; set; }
        public byte[] Content { get; set; }
        
        
        public void ImportFromFile(string Path)
        {
            //Pseudo-Implementierung. Import-Methode wird  für den PDF und JPEG  verwendet,
            //(Id, Title, Content) werden initialisiert
        }

        public void PrintPDF()
        {
            // Pseudo-Implementierung für das Drucken eines PDF-Documents
            //(Title, Content) werden zum Beispiel gedruckt
        }

        public void PrintJPEG()
        {
            // Pseudo-Implementierung für das Drucken eines PDF-Documents
            // (Title, Content) werden zum Beispiel gedruckt
        }
    }
    #endregion
}
