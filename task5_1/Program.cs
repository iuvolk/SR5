using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5_1
{
    class Program
    {
        static void Main(string[] args)
        {

            const int n = 7;
            int[] array = new int[n];
            int s = 0;
            int k = 0;
            
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                s += array[i];
                k++;

            }
            Console.Write("{0,4:f2}", ((double)s) / k);
            Console.ReadKey();
        }
    }
}