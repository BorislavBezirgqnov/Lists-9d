using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи брой елементи: ");
            int n = int.Parse(Console.ReadLine());
            List <int>numbers= new List<int>();
            //input
            for (int i = 0; i < n; i++)
            {
                Console.Write("Vavedi chislo: ");
                int item=int.Parse(Console.ReadLine());
                numbers.Add(item);
            }

            //obrabotka
            //dobavq v sredata
            //int newIndex = n / 2;//sredata na chislata
            //numbers.Insert(newIndex,6);
            ////dobavyane w kraya na MIN element
            //int minElement = numbers.Min();
            //numbers.Add(minElement);

            //da iztriq nulite vsichki
            //foreach (int chervenokvadratche in numbers)
            while (numbers.Countains(0))
            {
             numbers.Remove
                
             //numbers.Remove(0);
            }

            //pechat
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"numbers[{i}]={numbers[i]}");
            }
            Console.WriteLine("Броя на елементите в списъка е: "+numbers.Count);
        }
    }
}
