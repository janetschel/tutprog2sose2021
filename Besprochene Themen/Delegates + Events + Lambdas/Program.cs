using System;
using System.Collections;
using System.Linq;
using Tutorium_08._06._21.events;
using Tutorium_08._06._21.events.services;

namespace Tutorium_08._06._21
{
    class Program
    {
        public delegate void RechenOperation(int x, int y);

        public delegate void CleanUp();
        
        static void Main(string[] args)
        {
            /*
            // Delegates
            #region Delegates as Method Param
            var rechenOperation = new RechenOperation(Add);
            rechenOperation(10, 9);

            var cleanUp = new CleanUp(CleanUpImplementation);
            DoSomething(cleanUp);
            #endregion

            #region Linq & Lambdas
            var list = Enumerable
                .Range(1, 100)
                .Where(x => x % 2 == 0)
                .Average();

            var sum = 0;
            var cnt = 1;
            for (int i = 1; i < 100; i++)
                if (i % 2 == 0)
                {
                    cnt++;
                    sum += i;
                }

            // Average
            Console.WriteLine(sum / cnt);
            #endregion
            */
            
            // Delegates & Events an einem Beispiel

            #region Delegates & Events

            var freiwilligeFeuerwehr = new FreiwilligeFeuerwehr();
            var einsatz = new Einsatz { Meldung = "Blitzeinschlag"};

            var pagerService = new PagerService();
            var sirenenService = new SirenenService();
            var messagingService = new MessagingService();

            freiwilligeFeuerwehr.AlarmiereFeuerwehr += pagerService.AlarmiereFeuerwehr;
            freiwilligeFeuerwehr.AlarmiereFeuerwehr += sirenenService.AlarmiereFeuerwehr;
            freiwilligeFeuerwehr.AlarmiereFeuerwehr += messagingService.AlarmiereFeuerwehr;
            freiwilligeFeuerwehr.AlarmiereFeuerwehr -= messagingService.AlarmiereFeuerwehr;
            
            freiwilligeFeuerwehr.Alarmiere(einsatz);

            #endregion
        }

        public static int DoSomething(CleanUp method = null)
        {
            if (method != null)
            {
                method();
            }
            
            return 1;
        }

        public static void CleanUpImplementation()
        {
            Console.WriteLine("Clean up...");
        }

        public static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
    }
}
