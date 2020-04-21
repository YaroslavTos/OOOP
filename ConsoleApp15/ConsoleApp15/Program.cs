using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер месяца: ");
            int x = int.Parse(Console.ReadLine());
            if (x >= 3 && x <= 5) Console.WriteLine("Весна");
            else
            if (x >= 6 && x <= 8) Console.WriteLine("Лето");
            else
            if (x >= 9 && x <= 11) Console.WriteLine("Осень");
            else
            if (x == 12 || x <= 2) Console.WriteLine("Зима");
            else Console.WriteLine("ERROR");

            Console.ReadLine();

        }
    }
}
