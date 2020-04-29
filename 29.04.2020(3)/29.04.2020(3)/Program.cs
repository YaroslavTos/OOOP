using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._04._2020_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число n: ");
            int n = int.Parse(Console.ReadLine());
            int s=0;
            int i;
            for ( i = 1; i <= n; i++)
                s = s + (2 * i - 1);
            Console.WriteLine(n + "^2=" + s);

            Console.ReadKey(true);
            Console.ReadLine();
        }
    }
}
