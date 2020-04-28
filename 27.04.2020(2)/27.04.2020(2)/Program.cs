using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._04._2020_2_
{
    class Vector
    {
        public static double Length(Vector l)
        {
            return Math.Sqrt(l.X * l.X + l.Y * l.Y + l.Z * l.Z);
        }

        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public double X;
        public double Y;
        public double Z;
        public double GetLength()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }
        public static Vector operator +(Vector l, Vector r)
        {
            return new Vector(l.X + r.X, l.Y + r.Y, l.Z + r.Z);
        }
        public static Vector operator -(Vector l, Vector r)
        {
            return new Vector(l.X - r.X, l.Y - r.Y, l.Z - r.Z);
        }
        public static double operator *(Vector l, Vector r)
        {
            return (l.X * r.X + l.Y * r.Y + l.Z * r.Z);
        }

        
            public static double Cos(Vector l, Vector r)
        {
            
            return (l * r) / (l.GetLength() * r.GetLength());
        }
        public override string ToString()
        {
            return string.Format("({0},{1},{2})", X, Y, Z);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Vector v1 = new Vector(1, 2, 3);
            Vector v2 = new Vector(4, 5, 6);
            Vector v3 = v1 + v2;
            Vector v4 = v1 - v2;
            double m = v2 * v3;
            double c = Vector.Cos(v1, v2);

            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(v3);
            Console.WriteLine(v4);
            Console.WriteLine(m);

            Console.WriteLine();
            Console.WriteLine("cos ");
            Console.WriteLine(c);
            Console.ReadKey();

        }
    }
}
