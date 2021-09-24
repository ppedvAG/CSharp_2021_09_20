using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M012_03_EventEventHandler
{
    public delegate void Percent(int percent);
    public delegate void ResultNotify();

    public class ProcessBusinessLogic
    {
        public event Percent CurrentPercentStatus; //Wir gehen davon aus, dass diese zwei Properties von jemanden verwendet werden
        public event ResultNotify ProcessCompleted;

        public void StartProcess()
        {
            //Bearbeiten wir etwas

            for(int i = 0; i < 100; i++)
            {
                //Callback -> Prozentanzeige sind wir aktuell (aber ausserhalb der Klasse)
                OnProcessPercentStatus(i);
            }

            //Callback -> aber ausserhalb der Klasse -> FinishMeldung
            OnPreocessCompleted();
        }

        protected virtual void OnPreocessCompleted()
        {
            // Diese Methode ist dafür da, um die Events nach aussen zu tragen
            ProcessCompleted?.Invoke();
        }

        protected virtual void OnProcessPercentStatus(int percent)
        {
            // Diese Methode ist dafür da, um die Events nach aussen zu tragen
            CurrentPercentStatus?.Invoke(percent);
        }
    }
}
