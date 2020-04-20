using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program(); 
            obj.readdata();
            obj.leap();
        }

        int y;

        public void readdata() 
        {
            Console.WriteLine("Введите год четырьмя цифрами : ");

            y = Convert.ToInt32(Console.ReadLine());
        }

        public void leap()
        {
            if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
            {
                Console.WriteLine("{0} - високосный год", y);
            }
            else
            {
                Console.WriteLine("{0} -это не високосный год", y);
            }
            Console.ReadLine();
        }
    }
}