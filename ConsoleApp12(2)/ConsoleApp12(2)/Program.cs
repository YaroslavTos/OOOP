using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("номера маршрутов : ");
            Console.WriteLine("1,2 ");

            Console.Write("Введите номер маршрута : ");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.WriteLine("Остановка 'Восточная'");
                    break;
                case 2:
                    Console.WriteLine("Ул.Московская");
                    break;
                
                default:
                    Console.WriteLine("Нету такого маршрута");
                    break;
            }

            Console.ReadLine();
        }
    }
}
