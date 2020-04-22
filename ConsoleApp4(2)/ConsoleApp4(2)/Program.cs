using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. #FFFF0000 ");
            Console.WriteLine("2. #FF0000FF ");
            Console.WriteLine("3. #FF008000 ");
            Console.WriteLine("");
            Console.WriteLine("Введите номер цвета :");
            int color = int.Parse(Console.ReadLine());

            switch (color)
            {
                case 1:
                    Console.WriteLine("Красный");
                    break;
                case 2:
                    Console.WriteLine("Синий   ");
                    break;
                case 3:
                    Console.WriteLine("Зеленый");
                    break;
               
                default:
                    Console.WriteLine("неправильно введено число");
                    break;
            }
            Console.ReadLine();
        }
    }
}
