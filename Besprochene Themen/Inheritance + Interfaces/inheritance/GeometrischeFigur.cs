using System;

namespace Tutorium
{
    // SUPERKLASSE / ELTERNKLASSE
    public abstract class GeometrischeFigur
    {
        public abstract double BerechneUmfang();

        // virtual -> kann überschreiben in Kind
        // abstract -> MUSS überschreiben in Kind
    }
}