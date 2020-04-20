using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {

        static void Main(string[] args)
        {
            int den, min, stomin;
            double sto;

            Console.WriteLine("День недели ");
            den = int.Parse(Console.ReadLine());
            Console.WriteLine("стоимость минуты ");
            stomin = int.Parse(Console.ReadLine());
            Console.WriteLine("кол-во минут ");
            min = int.Parse(Console.ReadLine());




            if (den <= 5)
                Console.WriteLine(sto = min * stomin);


            else
                if (den >= 6 && den<=7)
                        Console.WriteLine(sto = (min * stomin) * ((min * stomin) * 15) / 100);
            else
                    if (den >= 8)
                Console.WriteLine("нету такого дня недели ");

            Console.ReadKey();
        
        }
    }
}
