using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЗАДАНИЕ 5.1");
            Console.WriteLine();
            Console.WriteLine("Сформировать одномерный массив из 7 элементов. Заполнить массив числами, вводимыми с клавиатуры,");
            Console.WriteLine("определить среднее арифметическое элементов.");
            Console.WriteLine();
            Console.WriteLine("********************************");
            Console.WriteLine();
            Console.WriteLine();
            const int m = 7;
            int avg = 0;
            int[] array = new int[m];
            for (int i = 0; i < m; i++)
            {
                int n = i+1; // Порядковый номер вводимого значения в массив, использую +1, чтобы значение i не менялось
                Console.WriteLine("Введите число №{0} массива", n);
                array[i] = Convert.ToInt32(Console.ReadLine());
                avg += array[i];
            }
            Console.WriteLine(">> СРЕДНЕЕ АРИФМЕТИЧЕСКОЕ В МАССИВЕ: {0:f2}", avg / m);
            Console.ReadKey();
        }
    }
}
