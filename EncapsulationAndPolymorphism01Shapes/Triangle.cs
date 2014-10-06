using System;

namespace EncapsulationAndPolymorphism01Shapes
{
    class Triangle:BasicShape
    {
        private double angle;

        public Triangle(double w, double h, double a)
            : base(w, h)
        {
            this.Angle = a;
        }
        public double Angle
        {
            get { return this.angle; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.angle = value;
            }
        }
        public override double CalculateArea()
        {
            return (Math.Sin(this.Angle * Math.PI / 180) * this.Width * this.Height) / 2;
        }

        public override double CalculatePerimeter()
        {
            return this.Width + this.Height + Math.Sqrt((this.Width * this.Width) + (this.Height * this.Height) - (2 * this.Height * this.Width * Math.Cos(this.Angle * Math.PI / 180)));
        }
    }
}
