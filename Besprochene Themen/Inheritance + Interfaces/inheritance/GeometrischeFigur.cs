using System;

namespace Tutorium
{
    // SUPERKLASSE / ELTERNKLASSE
    public abstract class GeometrischeFigur
    {
        public abstract double BerechneUmfang();

        // virtual -> kann ├╝berschreiben in Kind
        // abstract -> MUSS ├╝berschreiben in Kind
    }
}