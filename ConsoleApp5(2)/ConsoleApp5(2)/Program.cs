using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Каналов всего 3 : 1,2,3");
            Console.WriteLine("Введите номер  канала :");
            int C = int.Parse(Console.ReadLine());

            switch (C)
            {
                case 1:
                    Console.WriteLine("Первый канал");
                    break;
                case 2:
                    Console.WriteLine("ТНТ");
                    break;
                case 3:
                    Console.WriteLine("Канал 24");
                    break;

                default:
                    Console.WriteLine("Нету такого канала");
                    break;
            }
            Console.ReadLine();
        }
    }
}
