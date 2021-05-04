using System;

namespace Tutorium
{
    public class Kreis : GeometrischeFigur
    {
        public double radius;

        public override double BerechneUmfang()
        {
            return 2 * radius * Math.PI;
        }
    }
}