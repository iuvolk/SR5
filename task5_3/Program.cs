using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();

            //Сортировка по возрастанию для первых 5 чисел массива
            for (int i = 0; i < n ; i++)
            {
                for (int j = i + 1; j < n/2; j++)
                {
                    if (array[i] > array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", array[i]);
            }

            //Сортировка по убыванию для последних 5 чисел массива (Почему то работает по условию зачачи правильно в итоге вся строка)
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; (j> n/2 && j < n); j++)
                {
                    if (array[i] < array[j])
                    {
                        int t = array[j];
                        array[j] = array[i];
                        array[i] = t;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0;  i < n; i++)
            {
                Console.Write("{0} ", array[i]);
            }

            Console.ReadKey();
        }
    }
}
