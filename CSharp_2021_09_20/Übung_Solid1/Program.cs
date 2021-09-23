using System;

namespace Übung_Solid1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    #region Bad Code

    public class BadEmployee
    {
        public int Employee_Id { get; set; }
        public string Employee_Name { get; set; }

        public string ReportType { get; set; }

        /// <summary>
        /// This method used to insert into employee table
        /// </summary>
        /// <param name="em">Employee object</param>
        /// <returns>Successfully inserted or not</returns>
        public bool InsertIntoEmployeeTable(BadEmployee em)
        {
            // Insert into employee table.
            return true;
        }
        /// <summary>
        /// Method to generate report
        /// </summary>
        /// <param name="em"></param>


        public void GenerateReport(BadEmployee em)
        {
            if (ReportType == "CRS")
            {
                // Report generation with employee data in Crystal Report.
            }
            if (ReportType == "PDF")
            {
                // Report generation with employee data in PDF.
            }
        }
    }

    #endregion

    #region Lösung 
    //Lösung
    #region Datenstruktur + Repository
    public class Employee
    {
        public int Employee_Id { get; set; }
        public string Employee_Name { get; set; }
    }





    public interface IRepository
    {
        bool InsertIntoEmployeeTable(Employee em);
        //bool InsertIntoEmployeeTable(Employee[] ems);
    }

    public class EmployeeRepository : IRepository
    {
        public bool InsertIntoEmployeeTable(Employee em)
        {
            throw new NotImplementedException();
        }
    }
    #endregion



    #region Variante 1 
    public abstract class ReportGeneratorBase
    {
        public abstract void GenerateReport(Employee em);
    }

    public class PDFReport : ReportGeneratorBase
    {
        public override void GenerateReport(Employee em)
        {
            //....
        }
    }

    public class CRSReport : ReportGeneratorBase
    {
        public override void GenerateReport(Employee em)
        {
            //....
        }
    }

    #endregion
    #endregion













}
