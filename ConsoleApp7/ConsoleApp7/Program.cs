using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec;
            Console.WriteLine("vvedite secundi");
            sec = int.Parse(Console.ReadLine());
            var t = TimeSpan.FromSeconds(sec);

            Console.WriteLine(t);

            Console.ReadKey();
        }
    }
}
