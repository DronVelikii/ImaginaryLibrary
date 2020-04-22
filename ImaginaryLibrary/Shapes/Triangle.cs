using System;

namespace ImaginaryLibrary.Shapes
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : AbstractShape
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public override double GetArea()
        {
            if (_a < 0 || _b < 0 || _c < 0)
                throw new InvalidOperationException("a,b,c cannot be less than zero");

            var p = (_a + _b + _c) / 2;

            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }
    }
}