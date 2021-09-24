using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M012_03_EventEventHandler
{
    public class ProcessBusinessLogic2
    {
        public event EventHandler ProcessCompleted; //Wir gehen davon aus, dass diese eine Property von jemanden verwendet werden
        
        public event EventHandler ProcessCompletedNew;

        public event EventHandler CurrentPercent;

        public void ProcessStart()
        {


            //Bearbeite etwas wichtiges
            MyPercentArgs myPercentArgs = null;

            for(int i = 0; i < 100; i++)
            {
                myPercentArgs = new MyPercentArgs();
                myPercentArgs.CurrentPercentValue = i;

                OnCurrentPercent(myPercentArgs);
            }







            //Ergebnis wollen wir nach draußen mitteilen. 
            OnProcessCompleted(EventArgs.Empty); //EventArgs.Empty = Wir übergeben keinen Parameter in die Event-Methode 


            MyEventArgs myEventArgs = new MyEventArgs();
            myEventArgs.Uhrzeit = DateTime.Now;

            OnProcessCompletedNew(myEventArgs);




             
        }


        protected virtual void OnProcessCompleted(EventArgs e)
        {
            ProcessCompleted?.Invoke(this, e);
        }

        protected virtual void OnProcessCompletedNew(MyEventArgs e)
        {
            ProcessCompletedNew?.Invoke(this, e);
        }

        protected virtual void OnCurrentPercent(MyPercentArgs e)
        {
            CurrentPercent?.Invoke(this, e);
        }
    }

    public class MyPercentArgs : EventArgs
    {
        public int CurrentPercentValue { get; set; }
    }

    public class MyEventArgs : EventArgs
    {
        public DateTime Uhrzeit {get;set;}
    }


  
}
