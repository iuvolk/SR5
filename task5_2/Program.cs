using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 15;
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine();

            int max = array[0];
            foreach (int a in array)
            {
                if (a > max)
                    max = a;
            }
            Console.WriteLine("Самое большое число в массиве {0}",max);
            
            int min = array[0];
            foreach (int b in array)
            {
                if (b < min)
                    min = b;
            }
            Console.WriteLine("Самое малое число в массиве {0}", min);
            Console.WriteLine();
            Console.WriteLine("Сумма большего и меньшего элементов {0}", min+max);
            Console.ReadKey();
        }
    }
}
