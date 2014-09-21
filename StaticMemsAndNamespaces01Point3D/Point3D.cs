using System;

namespace StaticMemsAndNamespaces01Point3D
{
    class Point3D
    {
        private double x;
        private double y;
        private double z;
        private static readonly Point3D startingPoint = new Point3D(0, 0, 0);

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
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

        static void Main(string[] args)
        {
            //quick check
            Point3D one = new Point3D(3, 4.5, 3.2);
            Console.WriteLine(Point3D.StartingPoint);
            Console.WriteLine(one);

        }
    }
}
