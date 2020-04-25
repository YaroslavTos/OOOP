using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace строки1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "a b c d e f g a a s q t";
            string s2 = "a";

            int i = 0;  
            int x = -1;  
            int count = -1; 
            while (i != -1)
            {
                i = s1.IndexOf(s2, x + 1);
                x = i;
                count++;  
            }

            Console.WriteLine(count);
            Console.ReadLine();

        }
    }
}
