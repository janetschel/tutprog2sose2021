using System;

namespace Tutorium
{
    public class Rechteck : GeometrischeFigur
    {
        public double h;
        public double b;

        public Rechteck(double h, double b)
        {
            this.h = h;
            this.b = b;
        }

        public override double BerechneUmfang()
        {
            return 2 * h + 2 * b;
        }
    }
}