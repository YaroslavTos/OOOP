using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, r;
            //b - оптимальный вес
            Console.WriteLine("Введите свой рост в см");
            r = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите свой вес в кг");
            a = int.Parse(Console.ReadLine());

            b = r - 100;

            if (b > a)
                Console.WriteLine("Ваш оптимальный вес = {0}, вам необходимо поправиться", b);
            else if (b < a)
                Console.WriteLine("Ваш оптимальный вес = {0}, вам необходимо похудеть", b);
            else
                Console.WriteLine("Ваш оптимальный вес = {0}, все в порядке", b);

            Console.ReadKey();
        }
    }
    
}
