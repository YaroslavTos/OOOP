﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня недели:");
            int day = int.Parse(Console.ReadLine());

            switch (day)
             {
                case 1:
                    Console.WriteLine("понедельник");
                   break;
               case 2:
                    Console.WriteLine("вторник");
                   break;
               case 3:
                   Console.WriteLine("среда");
             break;
                case 4:
              Console.WriteLine("четверг");
             break;
                case 5:
             Console.WriteLine("пятница");
             break;
                 case 6:
              Console.WriteLine("суббота");
               break;
                    case 7:
                Console.WriteLine("воскресенье");
             break;
              default:
             Console.WriteLine("неправильно введено число");
              break;           
              }

            Console.ReadLine();
        }
    }
}
