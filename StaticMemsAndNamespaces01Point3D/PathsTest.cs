using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMemsAndNamespaces01Point3D
{
    class PathsTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Point3D.StartingPoint.ToString());

            Point3D a = new Point3D( 1, 3, 5.6);
            Point3D b = new Point3D( -1, 3, 5.6);
            Point3D c = new Point3D( 1, -3, 5.6);
            Point3D d = new Point3D( 1, 3, -5.6);

            Paths3D path = new Paths3D(a, b, c, d);
            Console.WriteLine(path.ToString());

            Console.WriteLine(DistanceCalc.CalculateDistance(a, d));

            //Storage tests
            Storage.SavePath(@"../../SavedPaths.txt", false, path);
            Storage.SavePath(@"../../SavedPaths.txt", true, path);

            var loadedList = Storage.LoadPaths(@"../..SavedPaths.txt");
            loadedList.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
