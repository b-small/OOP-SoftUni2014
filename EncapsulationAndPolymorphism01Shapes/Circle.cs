using System;

namespace EncapsulationAndPolymorphism01Shapes
{
    class Circle : IShape
    {
        private double radius;

        public Circle(double r)
        {
            this.Radius = r;
        }
        public double Radius
        {
            get { return this.radius; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.radius = value;
            }
        }
        public double CalculateArea()
        {
            return this.radius * this.radius * Math.PI;
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * this.radius;
        }
    }
}
