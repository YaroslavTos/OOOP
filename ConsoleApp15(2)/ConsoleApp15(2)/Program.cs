using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер буквы  : ");
            int x = int.Parse(Console.ReadLine());

            

            switch (x)
            {
                case 1:
                    Console.WriteLine("А");
                    break;
                case 2:
                    Console.WriteLine("Б");
                    break;
                case 3:
                    Console.WriteLine("В");
                    break;

                default:
                    Console.WriteLine("Нету такой буквы ");
                    break;
            }
         

            Console.ReadLine();
        }
    }
}
