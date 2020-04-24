using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace циклы1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] M = new int[20];

            M[0] = 1;

            for (int i = 0; i < M.Length; i++)
            {
                if (i == 19)
                {
                    Console.WriteLine(M[i]);
                    break;
                }

                M[i + 1] = M[i] + 3;

                Console.WriteLine(M[i]);
            }

            Console.ReadKey();
        }
    }
}
