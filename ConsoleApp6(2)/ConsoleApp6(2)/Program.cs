using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер месяца: ");
            int x = int.Parse(Console.ReadLine());
            
            switch (x)
            {
                case 1:
                    Console.WriteLine("январь-Зима");
                    break;
                case 2:
                    Console.WriteLine("февраль-Зима");
                    break;
                case 3:
                    Console.WriteLine("март-Весна");
                    break;

                case 4:
                    Console.WriteLine("апрель-Весна");
                    break;
                case 5:
                    Console.WriteLine("май-Весна");
                    break;
                case 6:
                    Console.WriteLine("июнь-Лето");
                    break;

                case 7:
                    Console.WriteLine("июль-Лето");
                    break;
                case 8:
                    Console.WriteLine("август-Лето");
                    break;
                case 9:
                    Console.WriteLine("сентябрь-Осень");
                    break;

                case 10:
                    Console.WriteLine("октябрь-Осень");
                    break;
                case 11:
                    Console.WriteLine("ноябрь-Осень");
                    break;
                case 12:
                    Console.WriteLine("декабрь-Зима");
                    break;

                default:
                    Console.WriteLine("Нету такого месяца");
                    break;
            }

            Console.ReadLine();
        }
    }
}
