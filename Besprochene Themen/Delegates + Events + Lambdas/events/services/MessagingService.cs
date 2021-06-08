using System;

namespace Tutorium_08._06._21.events.services
{
    public class MessagingService
    {
        public void AlarmiereFeuerwehr(object source, EinsatzEventArgs args)
        {
            Console.WriteLine($"MessagingService: Alarmiere mit Einsatzmeldung { args.Einsatz.Meldung }");
        }
    }
}