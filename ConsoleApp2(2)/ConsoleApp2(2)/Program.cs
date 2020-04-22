using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("skolko budet 2+2? ");
            Console.WriteLine("1. 3");
            Console.WriteLine("2. 4");
            Console.WriteLine("3. 5");
            Console.WriteLine("4. 6");
            Console.WriteLine("5. 1");

            Console.WriteLine();
            Console.WriteLine("vvedite nomer otveta");
            int A = int.Parse(Console.ReadLine());

            switch (A)
            {
                
                case 2:
                    Console.WriteLine("prav ");
                    break;
                default:
                    Console.WriteLine("neprav");
                    break;

            }

            
            Console.ReadLine();
        }
    }
}
