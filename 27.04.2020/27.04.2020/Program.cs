using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._04._2020
{
    class Program
    {
        class Address
        {
            int _index;
            String _country;
            String _city;
            String _street;
            int _house;
            int _office;

            public int index
            {
                get { return _index; }
                set { if (value <= 0) Console.WriteLine("неверный индекс"); else _index = value; }
            }

            public string country
            {
                get { return _country; }
                set { if (value.Length == 0) Console.WriteLine("неправильная страна"); else _country = value; }
            }

            public string city
            {
                get { return _city; }
                set { if (value.Length == 0) Console.WriteLine("неправильный город"); else _city = value; }
            }

            public string street
            {
                get { return _street; }
                set { if (value.Length == 0) Console.WriteLine("неправильная улица"); else _street = value; }
            }

            public int house
            {
                get { return _house; }
                set { if (value <= 0) Console.WriteLine("неверный номер дома"); else _house = value; }
            }

            public int office
            {
                get { return _office; }
                set { if (value <= 0) Console.WriteLine("неверный номер офиса"); else _office = value; }
            }

            public override string ToString()
            {
                return "[" +
                index + " " +
                country + " " +
                city + " " +
                street + " " +
                house + " " +
                office + "]";
            }

            public Address()
            {
            }

            public Address(int index_, String country_, String city_, String street_, int house_, int office_)
            {
                index = index_;
                country = country_;
                city = city_;
                street = street_;
                house = house_;
                office = office_;
            }

        }

        static void Main(string[] args)
        {
            Address addr = new Address(350064, "Russia", "Krasnodar", "Krasnaya st.", 45, 13);

            Console.WriteLine(addr);

            addr.street = "Коммунаров";
            Console.WriteLine(addr);

            addr.index = 0;
            Console.WriteLine(addr);
            Console.ReadLine();
        }
        
    }

}
