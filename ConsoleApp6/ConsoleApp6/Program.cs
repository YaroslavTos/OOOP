using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int A,B;
            double sto;

            Console.WriteLine("A: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("B: ");
            B = int.Parse(Console.ReadLine());


            if (A%2==0 && B%2==0)
                Console.WriteLine(sto=A+B);
            else
                   
                Console.WriteLine(sto = A-B);

            Console.ReadKey();

        }
    }
}
