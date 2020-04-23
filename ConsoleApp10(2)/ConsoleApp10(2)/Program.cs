using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 1 до 10 :");
            int ch = int.Parse(Console.ReadLine());


            for (int a = 1; a <= ch / a; a++)
                switch (ch)
                {
                    case 1:
                        if (ch % a == 0)
                        {
                            if (a != ch / a) Console.Write("{0} {1} ", a, ch / a);
                            else Console.Write("{0} ", a);
                            Console.WriteLine("число простое");
                        };
                        break;
                    case 2:
                        if (ch % a == 0)
                        {
                            if (a != ch / a) Console.Write("{0} {1} ", a, ch / a);
                            else Console.Write("{0} ", a);
                            Console.WriteLine("число простое");
                        }
                        break;
                    case 3:
                        if (ch % a == 0)
                        {
                            if (a != ch / a) Console.Write("{0} {1} ", a, ch / a);
                            else Console.Write("{0} ", a);
                            Console.WriteLine("число простое");
                        }
                        break;
                    case 4:
                        if (ch % a == 0)
                        {
                            if (a != ch / a) Console.Write("{0} {1} ", a, ch / a);
                            else Console.Write("{0} ", a);
                            Console.WriteLine("число Составное");
                        }
                        break;
                    case 5:
                        if (ch % a == 0)
                        {
                            if (a != ch / a) Console.Write("{0} {1} ", a, ch / a);
                            else Console.Write("{0} ", a);
                            Console.WriteLine("число простое");
                        }
                        break;
                    case 6:
                        if (ch % a == 0)
                        {
                            if (a != ch / a) Console.Write("{0} {1} ", a, ch / a);
                            else Console.Write("{0} ", a);
                            Console.WriteLine("число Составное");
                        }
                        break;
                    case 7:
                        if (ch % a == 0)
                        {
                            if (a != ch / a) Console.Write("{0} {1} ", a, ch / a);
                            else Console.Write("{0} ", a);
                            Console.WriteLine("число простое");
                        }
                        break;
                    case 8:
                        if (ch % a == 0)
                        {
                            if (a != ch / a) Console.Write("{0} {1} ", a, ch / a);
                            else Console.Write("{0} ", a);
                            Console.WriteLine("число Составное");
                        }
                        break;
                    case 9:
                        if (ch % a == 0)
                        {
                            if (a != ch / a) Console.Write("{0} {1} ", a, ch / a);
                            else Console.Write("{0} ", a);
                            Console.WriteLine("число простое");
                        }
                        break;
                    case 10:
                        if (ch % a == 0)
                        {
                            if (a != ch / a) Console.Write("{0} {1} ", a, ch / a);
                            else Console.Write("{0} ", a);
                            Console.WriteLine("число Составное");
                        }
                        break;


                    default:
                        Console.WriteLine("неправильно введено число");
                        break;
                }

            Console.ReadLine();
        }
    }
}
