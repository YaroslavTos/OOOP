using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int gorod, min, stomin;
            double sto;

            Console.WriteLine("выберете город ");
            Console.WriteLine("1: Moskva");
            Console.WriteLine("2: Nur-Sultan");
            Console.WriteLine("3: Piter");
            Console.WriteLine("");
            gorod = int.Parse(Console.ReadLine());
            Console.WriteLine("стоимость минуты ");
            stomin = int.Parse(Console.ReadLine());
            Console.WriteLine("кол-во минут ");
            min = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("цена - ");
            switch (gorod)
            {
                case 1:
                    
                    Console.WriteLine(sto = min * stomin);
                    break;
                case 2:
                    Console.WriteLine( sto = min * stomin);
                break;
                case 3:
                    Console.WriteLine( sto = min * stomin);
                break;

                default:
                    Console.WriteLine("Нету такого города в записной ");
                break;
            }
            Console.ReadLine();
        }
    }
}
