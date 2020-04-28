using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._04._2020_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            String s = Console.ReadLine();
            String[] arr = s.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            int max = arr.Max(str => str.Length); 
            string maxStr = arr.First(str => str.Length == max); 

            Console.Write("samaya bolshaya stroka : ");
            Console.Write(maxStr);
            Console.ReadLine();
        }
        
    }
}
