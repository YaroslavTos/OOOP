using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер месяца: ");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.WriteLine("1 января — Начало Нового года");
                    Console.WriteLine("1 декабря	День Первого Президента");
                    Console.WriteLine("1 мая — День единства народа Казахстана");
                    Console.WriteLine("1 июня — День защиты детей");
                    Console.WriteLine("1 сентября — День знаний");
                    break;
                case 5:
                    Console.WriteLine("5 апреля	День миграционной полиции Республики Казахстан");
                    Console.WriteLine("5 апреля	День геолога (первое воскресенье апреля)");
                    break;
                case 7:
                    Console.WriteLine("7 мая - День защитника Отечества");
                    Console.WriteLine("7 января	Рождество Христово");
                    break;
                case 8:
                    Console.WriteLine("8 марта	Международный женский день");
                    break;
                case 9:
                    Console.WriteLine("9 мая	День Победы");
                    break;
                case 10:
                    Console.WriteLine("10 января	День Национальной гвардии Республики Казахстан");
                    break;
                case 15:
                    Console.WriteLine("15 февраля	День вывода ограниченного контингента советских войск из Демократической Республики Афганистан");

                    break;
                case 16:
                    Console.WriteLine("16 декабря	День Независимости Казахстана");
                    break;
                case 17:
                    Console.WriteLine("17 декабря	День Независимости Казахстана");
                    break;
                case 21:
                    Console.WriteLine("21 марта	Наурыз мейрамы");
                    break;
                case 22:
                    Console.WriteLine("22 марта	Наурыз мейрамы");
                    break;
                case 23:
                    Console.WriteLine("23 марта	Наурыз мейрамы");
                    break;
                case 30:
                    Console.WriteLine("30 августа	День Конституции");
                    break;
                case 31:
                    Console.WriteLine("31 июля	Курбан Айт");
                    break;

                    

                default:
                    if (x >= 32)
                        Console.WriteLine("Ошибка ввода данных.");
                    else
                        Console.WriteLine("Это не праздничный день.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
