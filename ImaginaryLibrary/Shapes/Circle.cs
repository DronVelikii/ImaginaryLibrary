using System;

namespace ImaginaryLibrary.Shapes
{
    /// <summary>
    /// Окружность
    /// </summary>
    public class Circle : AbstractShape
    {
        private readonly double _r;

        /// <param name="r">Радиус в см</param>
        public Circle(double r)
        {
            _r = r;
        }


        public override double GetArea()
        {
            if (_r < 0)
                throw new InvalidOperationException("R cannot be less than zero");

            return Math.PI * _r * _r;
        }
    }
}