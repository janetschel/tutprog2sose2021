using System;
using System.Threading;
using Tutorium_08._06._21.events.services;

namespace Tutorium_08._06._21.events
{
    public class EinsatzEventArgs : EventArgs
    {
        public Einsatz Einsatz { get; set; }
    }
    
    public class FreiwilligeFeuerwehr
    {
        // Schritt 1 zu Events: Delegate erstellen Name+EventHandler
        public delegate void AlarmiereFeuerwehrEventHandler(object source, EinsatzEventArgs args);
        
        // Schritt 2 zu Events: Event erstellen
        public event AlarmiereFeuerwehrEventHandler AlarmiereFeuerwehr;
        
        // Schritt 3: Raise the event (Event aufrufen)
        
        public void Alarmiere(Einsatz einsatz)
        {
            Console.WriteLine("Alarmiere Einsatzkräfte...");
            Thread.Sleep(1000);
            
            // Alarmierung über verschiedene Wege
            OnAlarmiereFeuerwehr(einsatz);
        }
        
        // Schritt 3:
        protected virtual void OnAlarmiereFeuerwehr(Einsatz einsatz)
        {
            if (AlarmiereFeuerwehr == null)
            {
                return;
            }

            AlarmiereFeuerwehr(this, new EinsatzEventArgs { Einsatz = einsatz});
        }
    }
}