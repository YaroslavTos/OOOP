using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня недели:");
            int day = int.Parse(Console.ReadLine());

            if (day==1)
                Console.WriteLine("понедельник");
            if (day == 2)
                Console.WriteLine("вторник");
            if (day == 3)
                Console.WriteLine("среда");
            if (day == 4)
                Console.WriteLine("четверг");
            if (day == 5)
                Console.WriteLine("пятница");
            if (day == 6)
                Console.WriteLine("суббота");
            if (day == 7)
                Console.WriteLine("воскресенье");
            if (day >= 8)
                Console.WriteLine("ERROR");

            // switch (day)
            // {
            //    case 1:
            //        Console.WriteLine("понедельник");
            //       break;
            //   case 2:
            //        Console.WriteLine("вторник");
            //       break;
            //   case 3:
            //       Console.WriteLine("среда");
            // break;
            //    case 4:
            //  Console.WriteLine("четверг");
            // break;
            //    case 5:
            // Console.WriteLine("пятница");
            // break;
            //     case 6:
            //  Console.WriteLine("суббота");
            //   break;
            //        case 7:
            //    Console.WriteLine("воскресенье");
            // break;
            //  default:
            //  Console.WriteLine("неправильно введено число");
            //  break;           
            //  }
            
            Console.ReadLine();
        }
        
    }
}
