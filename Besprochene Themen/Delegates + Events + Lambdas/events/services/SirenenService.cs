using System;

namespace Tutorium_08._06._21.events.services
{
    public class SirenenService
    {
        public void AlarmiereFeuerwehr(object source, EinsatzEventArgs args)
        {
            Console.WriteLine($"SirenenService: Alarmiere mit Einsatzmeldung {args.Einsatz.Meldung}");
        }
    }
}