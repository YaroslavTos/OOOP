using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace строки3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            String s = Console.ReadLine();
            String[] arr = s.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Количество слов: {0}", arr.Length);
            Console.ReadLine();
        }
    }
}
