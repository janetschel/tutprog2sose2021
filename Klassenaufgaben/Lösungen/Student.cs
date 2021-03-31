using System;

namespace ConsoleApp2
{
    public class Student
    {
        private string _matrikelNummer;
        private string _name, _vorname;
        private uint _fachsemester;
        private double _notendurchschnitt;

        # region GetterSetter
        public string MatrikelNummer
        {
            get => _matrikelNummer;
            set
            {
                var matnr = Convert.ToInt32(value);
                if (matnr < 1 || matnr > 9999999)
                    throw new Exception("Matrikelnummer muss zwischen 0000001 und 9999999 sein!");

                _matrikelNummer = value;
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                if (value == "")
                    throw new Exception("Wert für Name darf nicht leer sein!");

                _name = value;
            }
        }

        public string Vorname
        {
            get => _vorname;
            set
            {
                if (value == "")
                    throw new Exception("Wert für den Vornamen darf nicht leer sein!");

                _vorname = value;
            }
        }

        public uint Fachsemester
        {
            get => _fachsemester;
            set
            {
                if (value < 1 || value > 10)
                    throw new Exception("Das Fachsemester muss zwischen 1 und 10 liegen.");

                _fachsemester = value;
            }
        }

        public double Notendurchschnitt
        {
            get => _notendurchschnitt;
            set
            {
                var decimalNotendurchschnitt = Convert.ToDecimal(value);
                var rounded = Decimal.Round(decimalNotendurchschnitt, 2);
                
                // analog zu https://stackoverflow.com/questions/6092243/c-sharp-check-if-a-decimal-has-more-than-3-decimal-places
                if (rounded != decimalNotendurchschnitt || rounded < 1.00m || rounded > 4.00m)
                    throw new Exception("Der Notendurschnitt muss 2 Nachkommastellen haben und zwischen 1,00 und 4,00 liegen.");

                _notendurchschnitt = value;
            }
        }
        #endregion

        public Student(string matrikelNummer, string name, string vorname, uint fachsemester, double notendurchschnitt)
        {
            MatrikelNummer = matrikelNummer;
            Name = name;
            Vorname = vorname;
            Fachsemester = fachsemester;
            Notendurchschnitt = notendurchschnitt;
        }

        public Student()
        {
            // hier soll nichts weiter passieren, nur der Aufruf mit einem leeren Konstruktor möglich gemacht werden
        }

        public override string ToString()
            => $"Student {{{MatrikelNummer}, {Name}, {Vorname}, {Fachsemester}. Fachsemester, {Notendurchschnitt}}}";

        public void SageHallo()
        {
            Console.WriteLine($"Hallo, mein Name ist {Vorname} {Name}");
        }
    }
}