using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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

        public static Point3D DeSerialize(string pointStr)
        {
            Regex rgx = new Regex(@"X: (.+?) Y: (.+?) Z: (.+?)}");
            MatchCollection matches = rgx.Matches(pointStr);
            var g = (matches[0] as Match).Groups;
            Point3D point = new Point3D(double.Parse(g[1].Value), double.Parse(g[2].Value), double.Parse(g[3].Value));

            return point;
        }
    }
}
