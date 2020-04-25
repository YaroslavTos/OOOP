using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace строки4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] x = new int[10];

            
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = r.Next(100);
                
                if (x[i] % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;                 
                }
                else
                {       
                    Console.ForegroundColor = ConsoleColor.Yellow;       
                }
                Console.WriteLine("x[" + i + "] = " + x[i] );                           
            }
            Console.WriteLine();

            Array.Sort(x);
            Array.ForEach(x, Console.WriteLine);
            Console.ReadLine();
        }
    }
}
