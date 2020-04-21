using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int metr,metr1,kylo;
            Console.WriteLine("vvedite metry");
            metr = int.Parse(Console.ReadLine());

            if (metr <= 999)
            {
                Console.WriteLine("metrrov: ", metr);
                Console.WriteLine(metr);
            }
            else if (metr == 1000)
            {
                Console.WriteLine("Kilo-Metrrov: ",kylo= metr / 1000);
                Console.WriteLine(kylo);
            }

            else if (metr >= 1000 && metr<=9999999)
            {            
                Console.WriteLine("Kilo-Metrrov: ", kylo = metr / 1000);
                Console.WriteLine(kylo);
                Console.WriteLine("metrrov: ", metr1 = metr-1000*kylo);
                Console.WriteLine(metr1);
            }


            Console.ReadKey();
        }
    }
}
