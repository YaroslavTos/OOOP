using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер месяца: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите номер дня: ");
            int d = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    if (d>=1 && d<=19)
                    {
                        Console.WriteLine("козерог");
                    }
                    else if (d >= 20 && d <= 30)
                    {
                        Console.WriteLine("Водолей");
                    }
                    break;
                case 2:
                    if (d >= 1 && d <= 18)
                    {
                        Console.WriteLine("Водолей");
                    }
                    else if (d >= 19 && d <= 29)
                    {
                        Console.WriteLine("рыбы");
                    }
                    break;
                case 3:
                    if (d >= 1 && d <= 20)
                    {
                        Console.WriteLine("рыбы");
                    }
                    else if (d >=21  && d <=29 )
                    {
                        Console.WriteLine("овен");
                    }
                    break;

                case 4:
                    if (d >= 1 && d <= 19)
                    {
                        Console.WriteLine("овен");
                    }
                    else if (d >= 20 && d <= 30)
                    {
                        Console.WriteLine("телец");
                    }
                    break;
                case 5:
                    if (d >= 1 && d <= 20)
                    {
                        Console.WriteLine("телец");
                    }
                    else if (d >= 21 && d <= 31)
                    {
                        Console.WriteLine("близнецы");
                    }
                    break;
                case 6:
                    if (d >= 1 && d <= 20)
                    {
                        Console.WriteLine("близнецы");
                    }
                    else if (d >= 21 && d <= 30)
                    {
                        Console.WriteLine("рак");
                    }
                    break;
                    break;

                case 7:
                    if (d >= 1 && d <= 22)
                    {
                        Console.WriteLine("рак");
                    }
                    else if (d >= 23 && d <= 31)
                    {
                        Console.WriteLine("лев");
                    }
                    break;
                case 8:
                    if (d >= 1 && d <= 22)
                    {
                        Console.WriteLine("лев");
                    }
                    else if (d >= 23 && d <= 31)
                    {
                        Console.WriteLine("дева");
                    }
                    break;
                case 9:
                    if (d >= 1 && d <= 22)
                    {
                        Console.WriteLine("дева");
                    }
                    else if (d >= 23 && d <= 30)
                    {
                        Console.WriteLine("весы");
                    }
                    break;

                case 10:
                    if (d >= 1 && d <= 22)
                    {
                        Console.WriteLine("весы");
                    }
                    else if (d >= 23 && d <= 31)
                    {
                        Console.WriteLine("скорпион");
                    }
                    break;
                case 11:
                    if (d >= 1 && d <= 21)
                    {
                        Console.WriteLine("скорпион");
                    }
                    else if (d >= 22 && d <= 30)
                    {
                        Console.WriteLine("стрелец");
                    }
                    break;
                case 12:
                    if (d >= 1 && d <= 21)
                    {
                        Console.WriteLine("стрелец");
                    }
                    else if (d >= 22 && d <= 30)
                    {
                        Console.WriteLine("козерог");
                    }
                    break;

                default:
                    Console.WriteLine("Нету такого месяца");
                    break;
            }

            Console.ReadLine();
        }
    }
}
