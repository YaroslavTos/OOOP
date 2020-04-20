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
            int A;
            int D;

            Console.WriteLine("запишите число А: ");
            A= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("запишите число B: ");
            D = Convert.ToInt32(Console.ReadLine());

            if ((A % 2) == 0)


                Console.WriteLine("Число {0} четное", A);
        else
                    Console.WriteLine("Число {0} нечетное", A);

            if ((D % 2) == 0)

                Console.WriteLine("Число {0} четное", D);
            else
                Console.WriteLine("Число {0} нечетное", D);

            
        }
    }
}
