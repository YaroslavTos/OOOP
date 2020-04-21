using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int min;
            Console.WriteLine("vvedite secundi");
            min = int.Parse(Console.ReadLine());
            var t = TimeSpan.FromMinutes(min);

            Console.WriteLine(t);

            Console.ReadKey();
        }
    }
}
