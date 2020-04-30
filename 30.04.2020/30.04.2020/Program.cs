using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._04._2020
{
    class Program
    {
        static void Main(string[] args)
        { 
        Console.Write("Введите значение a = ");
            float a = float.Parse(Console.ReadLine().Trim());
        Console.Write("Введите значение b = ");
            float b = float.Parse(Console.ReadLine().Trim());
        Console.Write("Введите значение c = ");
            float c = float.Parse(Console.ReadLine().Trim());

        float d = b * b - 4 * a * c;

            if (d< 0)
            {
                Console.Write("Дискриминант d < 0<!-- hu -->. Решение квадратного уравнения невозможно.");
            }
            else
            {
                float x1, x2;
                if (d == 0)
                {
                    x1 = x2 = -(b / 2 * a);
                }
                else
                {
                    float sqrtD = (float)System.Math.Sqrt(d);
                    x1 = (-b + sqrtD) / (2 * a);
                    x2 = (-b - sqrtD) / (2 * a);
                }
                
                Console.Write("d = " + d.ToString() + " x1 = " + x1.ToString() + " x2 = " + x2.ToString());
            }
           
            Console.ReadLine();
        }
    }
}
    
