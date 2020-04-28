using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._04._2020_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArr = new int[10, 10];
            Random ran = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    myArr[i, j] = ran.Next(1, 15);
                    Console.Write("{0}\t", myArr[i, j]);
                }
                Console.WriteLine();
            }

            Console.Write("сумма строк: ");
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {              
                for (int j = 0; j < 10; j++)
                {
                    sum += myArr[i, j];
                }
                Console.Write(" "+sum );
            }

            Console.WriteLine();
            Console.WriteLine();
            double mul = 1;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    mul *= myArr[i, j];
                }
                Console.WriteLine("Произведение "+ mul);
            }

            Console.WriteLine();
            Console.ReadKey(true);
            Console.ReadLine();
        }
    }
}
