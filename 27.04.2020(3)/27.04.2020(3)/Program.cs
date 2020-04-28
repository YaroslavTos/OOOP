using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._04._2020_3_
{
    class IntArray
    {
        private int[] _arr;

        public IntArray()
        {
            this._arr = new int[0];
        }

        public IntArray(int size)
        {
            this._arr = new int[size];
        }
        
        public int this[int index]
        {
            get
            {
                int res = int.MinValue;
                try
                {

                    res = this._arr[index];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Error: array doesn't have {0} element!", index);
                }

                return res;
            }
            set
            {
                if (index > -1 && index < this._arr.Length)
                    this._arr[index] = value;
            }
        }
        
        public int Count
        {
            get { return this._arr.Length; }
        }
       
        public static IntArray operator +(IntArray arr1, IntArray arr2)
        {
            IntArray res = new IntArray();
            if (arr1.Count == arr2.Count)
            {
                res = new IntArray(arr1.Count);
                for (int i = 0; i < res.Count; i++)
                    res[i] = arr1[i] + arr2[i];
            }
            return res;
        }
        
        public static IntArray operator -(IntArray arr1, IntArray arr2)
        {
            IntArray res = new IntArray();
            if (arr1.Count == arr2.Count)
            {
                res = new IntArray(arr1.Count);
                for (int i = 0; i < res.Count; i++)
                    res[i] = arr1[i] - arr2[i];
            }
            return res;
        }

        public static IntArray operator *(IntArray arr1, int number)
        {
            IntArray res = new IntArray(arr1.Count);
            for (int i = 0; i < arr1.Count; i++)
                res[i] = arr1[i] * number;
            return res;
        }

        public static IntArray operator /(IntArray arr1, int number)
        {
            IntArray res = new IntArray(arr1.Count);
            for (int i = 0; i < arr1.Count; i++)
                res[i] = arr1[i] / number;
            return res;
        }
        
        public void Print()
        {
            Console.Write("Array: ");
            for (int i = 0; i < _arr.Length; i++)
                Console.Write("{0} ", _arr[i]);
            Console.WriteLine();
        }
       
        public void Print(int index)
        {
            if (index > -1 && index < _arr.Length)
                Console.WriteLine("{0} element have value {1}", index, _arr[index]);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IntArray arr = new IntArray(10);
            IntArray arr2 = new IntArray(10);
            Random rand = new Random();
            for (int i = 0; i < arr.Count; i++)
                arr[i] = rand.Next(-10, 10);

            for (int i = 0; i < arr2.Count; i++)
                arr2[i] = rand.Next(-10, 10);

            arr.Print();
            Console.WriteLine();

            arr2.Print();
            Console.WriteLine();

            IntArray arr3 = arr + arr2;
            arr3.Print();
            Console.WriteLine();

            arr3 = arr - arr2;
            arr3.Print();
            Console.WriteLine();

            arr3 = arr * 2;
            arr3.Print();
            Console.WriteLine();

            arr3 = arr / 2;
            arr3.Print();
            Console.WriteLine();

            arr3.Print(2);
            Console.WriteLine(arr3[11]);

            Console.WriteLine();
            arr3.Print();
            Console.ReadLine();
        }
    }
}
