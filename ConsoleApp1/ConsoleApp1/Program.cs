using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите три целых числа: Y(год), M (месяц) и D (день), определяющие правильную дату.\n\tY (год) - ");
            try
            {
                int y = int.Parse(Console.ReadLine());
                if (y < 0) throw new ArgumentException("Год не может быть отрицательным");

                Console.Write("\tM (месяц 1-12) - ");
                int m = int.Parse(Console.ReadLine());
                if (m < 1 || m > 12) throw new ArgumentException("Номер месяца должен быть в диаппазоне 1-12");

                //Масив количества дней в месяце
                int[] mD = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                //Уточнение, если год високосный
                if (y % 400 == 0 || (y % 4 == 0 && y % 100 != 0))
                    mD[1] = 29;

                Console.Write("\tD (день 1-{0}) - ", mD[m - 1]);
                int d = int.Parse(Console.ReadLine());
                if (d < 1 || d > mD[m - 1]) throw new ArgumentException("В месяце №" + m + " " + y + " года, число может быть только в диаппазоне 1-" + mD[m - 1]);

                if (d != mD[m - 1])
                    d++;
                else if (m != 12)
                {
                    d = 1;
                    m++;
                }
                else
                {
                    d = m = 1;
                    y++;
                }

                Console.WriteLine("Следующим днем является {0:d4}-{1:d2}-{2:d2}", y, m, d);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }


    }


}
