using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число от 1 до 10 : ");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.WriteLine("1");
                    Console.WriteLine(x * x * x);
                    break;
                case 2:
                    Console.WriteLine("2");
                    Console.WriteLine(x * x * x);
                    break;
                case 3:
                    Console.WriteLine("3");
                    Console.WriteLine(x * x * x);

                    break;

                case 4:
                    Console.WriteLine("4");
                    
                    break;
                case 5:
                    Console.WriteLine("5");
                    Console.WriteLine(x * x * x);
                    break;
                case 6:
                    Console.WriteLine("6");
                    
                    break;

                case 7:
                    Console.WriteLine("7");
                    Console.WriteLine(x * x * x);
                    break;
                case 8:
                    Console.WriteLine("8");
                    
                    break;
                case 9:
                    Console.WriteLine("9");
                    Console.WriteLine(x * x * x);
                    break;

                case 10:
                    Console.WriteLine("10");
                    
                    break;
                

                default:
                    Console.WriteLine("ERROR");
                    break;
            }

            Console.ReadLine();

        }
    }
}
