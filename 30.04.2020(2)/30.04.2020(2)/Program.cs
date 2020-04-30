using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._04._2020_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение a = ");
            int a1 = int.Parse(Console.ReadLine().Trim());
            Console.Write("Введите значение b = ");
            int b1 = int.Parse(Console.ReadLine().Trim());
            Console.Write("Введите значение c = ");
            int c1 = int.Parse(Console.ReadLine().Trim());

           
            Console.WriteLine("S1 = {0}", Geron(a1, b1, c1));
            Console.Read();
        }
        static double Geron(int a, int b, int c)
        {
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }
    }
}
