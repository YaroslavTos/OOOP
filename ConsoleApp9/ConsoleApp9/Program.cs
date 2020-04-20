using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            double d, x1, x2;
            String a_string, b_string, c_string;

            Console.WriteLine("Введите значение a:");
            a_string = (Console.ReadLine());
            double a = double.Parse(a_string);
            Console.WriteLine("Введите значение b:");
            b_string = (Console.ReadLine());
            double b = double.Parse(b_string);
            Console.WriteLine("Введите значение c:");
            c_string = (Console.ReadLine());

            double c = double.Parse(c_string);
            d = b * b - 4 * a * c;
            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            x2 = (-b - Math.Sqrt(d)) / (2 * a);
            if (d >= 1) Console.Write($"Корни квадратного уравнения: {x1} {x2}");
            else Console.Write("Квадратное уравнение не имеет решений");

            Console.ReadLine();
        }
    }
}