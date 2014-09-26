﻿using System;

namespace StaticMemsAndNamespaces01Point3D
{
    static class DistanceCalc
    {
        public static double CalculateDistance(Point3D a, Point3D b)
        {
            double distance = Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2) + Math.Pow(b.Z - a.Z, 2));
            return distance;
        }
    }
}
