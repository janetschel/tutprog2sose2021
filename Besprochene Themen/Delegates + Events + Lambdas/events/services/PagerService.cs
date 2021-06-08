using System;

namespace Tutorium_08._06._21.events.services
{
    public class PagerService
    {
        public void AlarmiereFeuerwehr(object source, EinsatzEventArgs args)
        {
            Console.WriteLine($"PagerService: Alarmiere mit Einsatzmeldung {args.Einsatz.Meldung}");
        }
    }
}