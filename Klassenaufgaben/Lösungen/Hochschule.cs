using System;

namespace WiederholungKlassen
{
    public class Hochschule
    {
        private Student[] _eingeschriebeneStudenten;
        private int _anzahlStudenten;
        private string _name;

        public Student[] EingeschriebeneStudenten => _eingeschriebeneStudenten;

        public int AnzahlStudenten => _anzahlStudenten;

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 5)
                    throw new Exception("Name für die Hochschule zu kurz!");

                _name = value;
            }
        }
        
        public Student this[int index]
        {
            get => Peek(index);
        }

        public Hochschule(Student[] eingeschriebeneStudenten, string name)
        {
            if (eingeschriebeneStudenten == null || eingeschriebeneStudenten.Length < 1)
                throw new Exception("Das Studentenarray muss mindestens einen Studenten enthalten!");

            _eingeschriebeneStudenten = eingeschriebeneStudenten;
            _anzahlStudenten = eingeschriebeneStudenten.Length;
            Name = name;
        }

        public override string ToString()
            => $"Die Hochschule \"{Name}\" hat {AnzahlStudenten} eingeschriebene Studenten.";

        public Student SucheStudent(string matrikelNummer)
        {
            foreach (var student in EingeschriebeneStudenten)
            {
                if (student.MatrikelNummer == matrikelNummer)
                    return student;
            }

            throw new Exception($"Studen mit Matrikelnummer {matrikelNummer} nicht gefunden.");
        }

        public void GebeStudentAus(string matrikelNummer)
        {
            var student = SucheStudent(matrikelNummer);
            Console.WriteLine(student);
        }

        public Student Peek(int index)
        {
            if (index < 0 || index >= AnzahlStudenten)
                throw new Exception("Dieser Index existiert auf dem Array nicht!");

            return EingeschriebeneStudenten[index];
        }

        public static Hochschule operator +(Hochschule first, Hochschule second)
        {
            var firstLength = first.EingeschriebeneStudenten.Length;
            var secondLength = second.EingeschriebeneStudenten.Length;
            
            var newEingeschriebeneStudenten = new Student[firstLength + secondLength];

            for (var i = 0; i < firstLength; i++)
                newEingeschriebeneStudenten[i] = first.EingeschriebeneStudenten[i];

            for (var i = 0; i < secondLength; i++)
            {
                newEingeschriebeneStudenten[firstLength + i] = second.EingeschriebeneStudenten[i];
            }

            var newName = $"Kombi-HS. aus: {first.Name} und {second.Name}";

            var kombi = new Hochschule(newEingeschriebeneStudenten, newName);
            
            // Konsolenausgabe erst NACH dem Anlegen des Objektes, falls es noch einen Fehler geben sollte
            Console.WriteLine("Neue Kombi-Hochschule erfolgreich erstellt!"); 
            return kombi;
        } 
    }
}