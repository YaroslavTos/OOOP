using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("какую сумму можно заработать ? ");
            Console.Write("введите кол-во правильных ответов: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("ваш приз : ");
            switch (n)
            {
                case 1:
                    Console.WriteLine("100 руб");
                    break;
                case 2:
                    Console.WriteLine("200 руб");
                    break;
                case 3:
                    Console.WriteLine("300 руб");
                    break;

                case 4:
                    Console.WriteLine("500 руб");
                    break;
                case 5:
                    Console.WriteLine("1000 руб ");
                    break;
                case 6:
                    Console.WriteLine("2000 руб ");
                    break;

                case 7:
                    Console.WriteLine("4000 руб");
                    break;
                case 8:
                    Console.WriteLine("8000 руб");
                    break;
                case 9:
                    Console.WriteLine("16 000 руб");
                    break;

                case 10:
                    Console.WriteLine("32 000 руб");
                    break;
                case 11:
                    Console.WriteLine("64 000 руб");
                    break;
                case 12:
                    Console.WriteLine("125 000 руб ");
                    break;

                default:
                    Console.WriteLine("Конец программы ");
                    break;
            }

            Console.ReadLine();
        }
    }
}
