using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЗАДАНИЕ 5.5");
            Console.WriteLine();
            Console.WriteLine("Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN следующего вида:");
            Console.WriteLine("1 0 1 0 1");
            Console.WriteLine("0 1 0 1 0");
            Console.WriteLine("1 0 1 0 1");
            Console.WriteLine("0 1 0 1 0");
            Console.WriteLine("1 0 1 0 1");
            Console.WriteLine();
            Console.WriteLine("********************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("ВВЕДИТЕ РАЗМЕРНОСТЬ МАССИВА NxN:");
            int m = Convert.ToInt32(Console.ReadLine());
            if (m < 0)
            {
                do
                {
                    Console.WriteLine(">> ВВЕДЕНА ОТРИЦАТЕЛЬНАЯ РАЗМЕРНОСТЬ МАССИВА ({0}), ПОВТОРИТЕ ВВОД...", m);
                    m = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                } while (m < 0);
            }
            Console.WriteLine();
            int[,] array = new int[m, m];
            for (int i = 0; i < m; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (j % 2 == 0)
                        {
                            array[i, j] = 1;
                        }
                        else
                        {
                            array[i, j] = 0;
                        }
                        Console.Write("{0,2}", array[i, j]);
                    }
                }
                else
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (j % 2 == 0)
                        {
                            array[i, j] = 0;
                        }
                        else
                        {
                            array[i, j] = 1;
                        }
                        Console.Write("{0,2}", array[i, j]);
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
