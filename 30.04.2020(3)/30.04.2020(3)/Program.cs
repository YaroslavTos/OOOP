using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._04._2020_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a= ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b= ");
            int b = int.Parse(Console.ReadLine());
            int result = 1;
            int result2 = 1;
            int result3 = 1;

            for (int i = a; i <= b; i++)
            {
                if (i % 2 != 0)
                {
                    result *= i;
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("for= " + result);



            for (int i = a; i <= b; i++)
            {
                do
                {
                    if (i % 2 != 0)
                    {
                        result2 *= i;
                    }

                    i++;
                } while (i <= b);
            }
            Console.WriteLine();
            Console.WriteLine("do-while= " + result2);
            


            for (int i = a; i <= b; i++)
            {
                while (i <= b) 
                {
                    if (i % 2 != 0)
                    {
                        result3 *= i;
                    }
                    i++;
                } 
            }
            Console.WriteLine();
            Console.WriteLine("while= " + result3);
            Console.ReadLine();
        }
    }
}
