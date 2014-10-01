using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaticMemsAndNamespaces01Point3D
{
    class Paths3D
    {
 
        private IList<Point3D> paths;

        public Paths3D(params Point3D[] points3D)
        {
            this.Paths = points3D.ToList();
        }

        public IList<Point3D> Paths
        {
            get { return this.paths; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.paths = value;
            }

        }

        public int Count
        {
            get { return this.Paths.Count; }
        }

        public Point3D this[int index]
        {
            get { return this.Paths[index]; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.Paths[index] = value;
            }
        }

        public void Add(Point3D point)
        {
            this.Paths.Add(point);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                sb.Append(this[i].ToString());
                if (i != this.Count - 1) { sb.Append(", "); }
            }
            return sb.ToString();
        }


    }
}
