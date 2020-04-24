using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace циклы2
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "root", input = string.Empty;
            while (input != password)
            {
                Console.WriteLine("Введите пароль:");
                input = Console.ReadLine();
            }
            Console.WriteLine("Пароль принят");
            Console.Read();
        }
    }
}
