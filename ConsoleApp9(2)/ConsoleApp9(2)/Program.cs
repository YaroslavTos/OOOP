using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9_2_
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
                    Console.WriteLine("1 квартал");
                    break;
                case 2:
                    Console.WriteLine("1 квартал");
                    break;
                case 3:
                    Console.WriteLine("1 квартал");
                    break;

                case 4:
                    Console.WriteLine("2 квартал");
                    break;
                case 5:
                    Console.WriteLine("2 квартал");
                    break;
                case 6:
                    Console.WriteLine("2 квартал");
                    break;

                case 7:
                    Console.WriteLine("3 квартал");
                    break;
                case 8:
                    Console.WriteLine("3 квартал");
                    break;
                case 9:
                    Console.WriteLine("3 квартал");
                    break;

                case 10:
                    Console.WriteLine("4 квартал");
                    break;
                case 11:
                    Console.WriteLine("4 квартал");
                    break;
                case 12:
                    Console.WriteLine("4 квартал");
                    break;

                default:
                    Console.WriteLine("Нету такого месяца");
                    break;
            }

            Console.ReadLine();
        }
    }
}
