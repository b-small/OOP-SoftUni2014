
using System;
namespace EncapsulationAndPolymorphism01Shapes
{
    abstract class BasicShape : IShape
    {
        private double width;
        private double height;

        public BasicShape(double w, double h)
        {
            this.Width = w;
            this.Height = h;
        }

        public double Width
        {
            get { return this.width; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.width = value;
            }
        }
        public double Height
        {
            get { return this.height; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.height = value;
            }
        }
        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
        
    }
}
