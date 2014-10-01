using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace StaticMemsAndNamespaces01Point3D
{
    class Storage
    {
        public static void SavePath(string fullFilename, bool append, Paths3D path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(fullFilename, append, Encoding.GetEncoding("UTF-8")))
                {
                    sw.WriteLine(path.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex.InnerException;
            }
        }

        public static List<Paths3D> LoadPaths(string fullFilename)
        {
            try
            {
                List<Paths3D> paths = new List<Paths3D>();
                using (StreamReader sr = new StreamReader(fullFilename, Encoding.GetEncoding("UTF-8")))
                {

                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        Paths3D points = new Paths3D();
                        var lines = line.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (var l in lines)
                        {
                            points.Add(Point3D.DeSerialize(l));
                        }

                        line = sr.ReadLine();
                        paths.Add(points);
                    }
                }
                return paths;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex.InnerException;
            }


        }
    }
}
