using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace массивы2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел в массиве");
            Console.Write("N=");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] k = new int[n];
            Random r = new Random();
            Console.WriteLine();

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < n; i++)
            {
                k[i] = r.Next(-10, 10);
                Console.Write(k[i] + " ");
            }
            Console.WriteLine();

            int max = k[0];

            for (int i = 0; i < n; i++)
            {
                if (k[i] > max) max = k[i];
            }
            Console.WriteLine();

            Console.WriteLine("Максимальный элемент массива: " + max);

            Console.ReadKey();
        }
    }
}
