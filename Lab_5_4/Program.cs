using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЗАДАНИЕ 5.4");
            Console.WriteLine();
            Console.WriteLine("Сформировать одномерный массив из 20 случайных чисел в диапазоне [-50;50].");
            Console.WriteLine("Определить количество нечетных положительных элементов, стоящих на четных местах.");
            Console.WriteLine();
            Console.WriteLine("********************************");
            Console.WriteLine();
            Console.WriteLine();
            const int m = 20;
            string mass = null;
            int[] array = new int[m];
            Random random = new Random();
            for (int i = 0; i < m; i++)
            {
                array[i] = random.Next(-50, 50);
                mass += Convert.ToString(array[i]) + " ";
                if (i == m - 1)
                {
                    Console.WriteLine(">> СГЕНЕРИРОВАННЫЙ МАССИВ: {0}", mass);
                    Console.WriteLine();
                }
            }
            int n = 0;
            for (int i = 0; i < m; i = i + 2)
            {
                int p = array[i] % 2;
                _ = (array[i] > 0 && p > 0) ? n++ : n;
            }
            Console.WriteLine(">> КОЛИЧЕСТВО НЕЧЕТНЫХ ПОЛОЖИТЕЛЬНЫХ ЭЛЕМЕНТОВ, СТОЯЩИХ НА ЧЕТНЫХ МЕСТАХ: {0}", n);
            Console.ReadKey();
        }
    }
}
