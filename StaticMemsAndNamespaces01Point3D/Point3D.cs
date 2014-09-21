using System;

namespace StaticMemsAndNamespaces01Point3D
{
    class Point3D
    {
        private double x;
        private double y;
        private double z;
        private static readonly Point3D startingPoint = new Point3D(0, 0, 0);
   
        public Point3D(double x1, double x2, double x3)
        {
            this.X = x1;
            this.Y = x2;
            this.Z = x3;
        }

        public double X
        {
            get { return this.x; }
            set
            {
                this.x = value;
            }
        }

        public double Y
        {
            get { return this.y; }
            set
            {
                this.y = value;
            }
        }

        public double Z
        {
            get { return this.z; }
            set
            {
                this.z = value;
            }
        }

        public static Point3D StartingPoint
        {
            get { return startingPoint; }
        }

        public override string ToString()
        {
            return string.Format("X: {0} Y: {1} Z: {2}", this.X, this.Y, this.Z);
        }
    }
}
