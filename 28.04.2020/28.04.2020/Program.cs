using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._04._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите число элементов массива");
            n = Convert.ToInt16(Console.ReadLine());
            double[] Data = new double[n];
            int i = 0;
            while (i < n)
            {
                Console.WriteLine("Введите элемент массива");           
                Data[i] = double.Parse(Console.ReadLine());
                Console.WriteLine();
                i++;
            }
            
            for (i = 0; i < n; i = i + 1)
                Console.WriteLine("Элемент[" + i + "]: " + Data[i]);
            Console.ReadKey();
        }
    }
}
