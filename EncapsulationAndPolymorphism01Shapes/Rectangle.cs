using System;

namespace EncapsulationAndPolymorphism01Shapes
{
    class Rectangle : BasicShape
    {
        public Rectangle(double w, double h)
            : base(w, h)
        {

        }
        public override double CalculateArea()
        {
            return this.Width * this.Height;
        }

        public override double CalculatePerimeter()
        {
            return 2*(this.Width + this.Height);
        }
    }
}
