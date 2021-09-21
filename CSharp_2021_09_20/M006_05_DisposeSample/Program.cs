using System;
using System.Data.SqlClient;
using System.IO; //File / Directory / Streams
using System.Text;

namespace M006_05_DisposeSample
{
    class Program
    {
        
        static void Main(string[] args)
        {
            SaveToFile();
            ConnectionToDB();
            PersonInUsingSample();
        }

        #region try/catch/finally 
        public static void SaveToFile()
        {
            string path = @"c:\temp\MyTest.txt";
            
            //Wenn eine MyTest.txt vorhanden ist, wird diese gelöscht 
            if (File.Exists(path))
            {
                File.Delete(path);
            }


            FileStream fs = null;

            try
            {
                //Sensiblen Quellcode, in dem ein Fehler passieren könnte 
                fs = File.Create(path);

                AddText(fs, "ABC");
                AddText(fs, "DEF");
            }
            catch (IOException ex) //Ist es ein Fehler bezüglich Zugriff auf Dateien oder Schreiben in Dateien 
            {
                Console.WriteLine("Fehler beim Schreiben");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                // Wann werde ich aufgerufen -> IMMER -> (Im Sauberen Durchlauf + Im Fehlerfall )

                fs.Flush(); //Schreibe alles raus, was noch im Buffer vorhanden ist
                fs.Close(); // Gebe die Datei im FileSystem wieder frei.
            }



        }

        public static void ConnectionToDB()
        {
            SqlConnection con = null;

            try
            {
                //con = new SqlConnection("AnyConnectionString");
                // Mal angenommen hier passiert ein Fehler, sind wir froh, dass die
                // Connection immer noch abgebaut wird. 
            }
            catch
            {

            }
            finally
            {
                // Egal was passiert, du wirst so oder so gelosed :-) 
                //con.Close();
            }

        }
        #endregion
        #region Using-Samples with FileStream
        public static void UsingSample1()
        {
            string path = @"c:\temp\MyTest.txt";

            using (FileStream fs = File.Create(path))
            {
                AddText(fs, "XYZ");
            }// <---- !!!  // Ende von Using ist sehr interrsant 
            // Am Ende des Using wird das FileStream-Object fs komplett abgebaut (Im Fehlerfall oder Normalfall)
        }

        public static void ModernUsing()
        {
            string path = @"c:\temp\MyTest.txt";

            using FileStream fs = File.Create(path);


        } //Hier wird Using augefordert, dass FileStream abgebaut wird -> Im Fehlerfall / Normalfall 


        private static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }
        #endregion

        public static void PersonInUsingSample()
        {
            #region .NET 2.0  - try catch finally
            Person oldPerson = null;

            try
            {
                oldPerson = new Person() { Id = 1, FirstName = "Kevin", LastName = "Winter" };
            }
            catch
            {

            }
            finally //wird immer aufgerufen 
            {
                oldPerson = null;
            }



            #endregion


            #region Variante using

            using (Person p = new Person() )
            {

            } //using calles Dispose()-Methode von Person 
            #endregion

        }
    }
}
