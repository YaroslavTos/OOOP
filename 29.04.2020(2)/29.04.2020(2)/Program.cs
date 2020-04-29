using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._04._2020_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N");
            int N = int.Parse(Console.ReadLine());
            string obr = "";

            while (N > 9)
            {
                obr += (N % 10).ToString();
                N = N / 10;
            }

            obr += N.ToString();
            Console.WriteLine("Число наоборот " + obr);
            Console.ReadLine();

        }
    }
}
