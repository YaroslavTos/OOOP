using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int A ;
            Console.WriteLine("skolko budet 2+2? ");
            Console.WriteLine("1. 3");
            Console.WriteLine("2. 4");
            Console.WriteLine("3. 5");
            Console.WriteLine();
            Console.WriteLine("vvedite nomer otveta");
            A = int.Parse(Console.ReadLine());

            if (A==2)
            {
                Console.WriteLine("pravilno ");
            }
            else
            {
                Console.WriteLine("neverno");
            }

            Console.ReadLine();
        }
    }
}
