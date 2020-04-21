using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {

            int A;
            

            Console.WriteLine("A: ");
            A = int.Parse(Console.ReadLine());


            if (A%2==0 ? true : false)
                Console.WriteLine("chetnye",A);
            else
                Console.WriteLine("Ne chetnye", A);

            Console.ReadLine();
        }
    }
}
