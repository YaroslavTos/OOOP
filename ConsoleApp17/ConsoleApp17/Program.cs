using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            int A,B;


            Console.WriteLine("A: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("B: ");
            B = int.Parse(Console.ReadLine());


            if (A == B)
                Console.WriteLine("chisla ravni");
            else if (A>B)
                Console.WriteLine("chislo A bolshe");
            else if (A<B)
                Console.WriteLine("chislo B bolshe");

            Console.ReadLine();
        }
    }
}
