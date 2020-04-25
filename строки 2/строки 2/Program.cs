using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace строки_2
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
            for (int i = 0; i <10; i++)
            {
                int sum = 0;
                for (int j = 0; j < 10; j++)
                {
                    sum += myArr[i, j];
                }
                Console.Write(sum + " ");        
            }

            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                int mul = 1;
                for (int j = 0; j < 10; j++)
                    mul *= myArr[j, i];
                Console.WriteLine("Произведение {0}-го столбца: {1}", i, mul);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("наибольшее число глав диагонали: ");
            int max = int.MinValue;
            for (int i = 0; i < myArr.GetLength(0); i++)
            {
                if (myArr[i, i] > max)
                    max = myArr[i, i];
                
            }
            Console.WriteLine(max);

            Console.ReadKey(true);
            Console.ReadLine();  
        }
    }
}
