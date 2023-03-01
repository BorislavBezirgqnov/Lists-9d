using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace febunachi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>number = new List<int>();
            number.Add(1);
            number.Add(1);
            Console.WriteLine("Koe подред число на Фибоначи искаш да вкараш? " +
            "\n N =");
            byte numFib=byte.Parse(Console.ReadLine());
            for (int i = 2; i < numFib; i++)
            {
                number.Add(number[i - 1]);
            }

            Console.WriteLine(string.Join(", ",number));

        }
    }
}
