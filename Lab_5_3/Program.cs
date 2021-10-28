using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЗАДАНИЕ 5.3");
            Console.WriteLine();
            Console.WriteLine("Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50;50].");
            Console.WriteLine("Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.");
            Console.WriteLine();
            Console.WriteLine("********************************");
            Console.WriteLine();
            Console.WriteLine();
            const int m = 10;
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
            for (int i = 0; i < m / 2 - 1; i++)
            {
                for (int j = i + 1; j <= m / 2 - 1; j++)
                {
                    if (array[i] > array[j])
                    {
                        int n = array[j];
                        array[j] = array[i];
                        array[i] = n;
                    }
                }
            }
            for (int i = m / 2; i < m - 1; i++)
            {
                for (int j = i + 1; j <= m - 1; j++)
                {
                    if (array[i] < array[j])
                    {
                        int n = array[j];
                        array[j] = array[i];
                        array[i] = n;
                    }
                }
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.ReadKey();
        }
    }
}
