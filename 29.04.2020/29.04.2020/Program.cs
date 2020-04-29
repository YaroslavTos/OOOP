using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._04._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите степень: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите число для возведения: ");
            double d = Chislo(Console.ReadLine());
            Console.WriteLine(func(n, d));
            Console.ReadKey();
        }

        static double Chislo(string text)
        {
            if (text.Contains("."))
            {
                text = text.Replace(".", ",");
            }
            return double.Parse(text);
        }

        static double func(int n, double a)
        {
            if (n == 0)
                return 1;
            if (n == 1)
                return a;
            else
            {
                n--;
                return a * func(n, a);
            }
        }
    }
}
