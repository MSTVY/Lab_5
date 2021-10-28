using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЗАДАНИЕ 5.2");
            Console.WriteLine();
            Console.WriteLine("Сформировать одномерный массив из 15 элементов, которые выбираются случайным образом из диапазона [0; 50].");
            Console.WriteLine("Определить сумму максимального и минимального элементов массива.");
            Console.WriteLine();
            Console.WriteLine("********************************");
            Console.WriteLine();
            Console.WriteLine();
            const int m = 15;
            string mass = null;
            int[] array = new int[m];
            Random random = new Random();
            for (int i = 0; i < m; i++)
            {
                array[i] = random.Next(0, 50);
                mass += Convert.ToString(array[i])+" ";
                if (i == m-1)
                {
                    Console.WriteLine(">> СГЕНЕРИРОВАННЫЙ МАССИВ: {0}", mass);
                    Console.WriteLine();
                }
            }
            int max, min;
            max = min = array[0];
            foreach (int a in array)
            {
                if (max < a)
                {
                    max = a;
                }
                else
                {
                    if (min > a)
                    {
                        min = a;
                    }
                }
            }
            Console.WriteLine(">> СУММА НАИБОЛЬШЕГО И НАИМЕНЬШЕГО ЧИСЕЛ В МАССИВЕ ({0} и {1}): {2}", max, min, min + max);
            Console.ReadKey();
        }
    }
}
