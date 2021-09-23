using System;

namespace Übung_Solid2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    #region Bad Sample
    public class BadEmail
    {
        public void SendEmail()
        {
            // code to send mail
        }
    }

    public class BadNotification
    {
        private BadEmail _email;
        public BadNotification()
        {
            _email = new BadEmail();
        }

        public void PromotionalNotification()
        {
            _email.SendEmail();
        }
    }
    #endregion

}
