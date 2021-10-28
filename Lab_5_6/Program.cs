using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЗАДАНИЕ 5.6");
            Console.WriteLine();
            Console.WriteLine("Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN.  ");
            Console.WriteLine("Заполнить массив числами, вводимыми с клавиатуры. Проверить, является ли введенная с клавиатуры ");
            Console.WriteLine("матрица магическим квадратом. ");
            Console.WriteLine();
            Console.WriteLine("P.S.");
            Console.WriteLine("Магическим квадратом называется матрица, сумма элементов которой в каждой строке, в каждом столбце");
            Console.WriteLine("и по каждой диагонали одинакова.");
            Console.WriteLine();
            Console.WriteLine("P.S.S.");
            Console.WriteLine("Выполнил задачу исходя из определения на википедии (https://ru.wikipedia.org/wiki/Магический_квадрат).");
            Console.WriteLine();
            Console.WriteLine("********************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("ВВЕДИТЕ РАЗМЕРНОСТЬ МАССИВА NxN (минимум 3):");
            int m = Convert.ToInt32(Console.ReadLine());
            int a = 0; // Фактическая контрольная сумма в строке
            int b = 0; // Фактическая констрольная сумма в столбце
            int c = 0; // Фактическая контрольная сумма по диагонали 1
            int d = 0; // Фактическая контрольная сумма по диагонали 2
            if (m < 3)
            {
                do
                {
                    if (m < 0)
                    {
                        Console.WriteLine(">> ВВЕДЕНА ОТРИЦАТЕЛЬНАЯ РАЗМЕРНОСТЬ МАССИВА ({0}), ПОВТОРИТЕ ВВОД...", m);
                        m = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                    }
                    else
                    {
                        if (m >= 0 && m < 3)
                        {
                            Console.WriteLine(">> МИНИМАЛЬНАЯ РАЗМЕРНОСТЬ МАССИВА 'МАГИЧЕСКИЙ КВАДРАТ' - 3, ВВЕДЕНО: {0}, ПОВТОРИТЕ ВВОД...", m);
                            m = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                        }
                    }

                } while (m < 3);
            }
            Console.WriteLine();
            int[,] array = new int[m, m];
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("ВВЕДИТЕ ЗНАЧЕНИЯ СТРОКИ {0} МАТРИЦЫ {1}x{1}", i + 1, m);
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(">> ВВЕДЕНА СЛЕДУЮЩАЯ МАТРИЦА {0}x{0}:", m);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,2}", array[i, j]);
                }
                Console.WriteLine();
            }
            int n = m * (Convert.ToInt32(Math.Pow(m, 2)) + 1) / 2; // Контрольная сумма для матрицы размерности m
            Console.WriteLine();
            Console.WriteLine(">> КОНТРОЛЬНАЯ СУММА ДЛЯ МАГИЧЕСКОГО КВАДРАТА: {0}", n);
            Console.WriteLine();
            for (int i = 0; i < m; i++) // Считаем суммы в строках
            {
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                for (int j = 0, k = m - 1; j < m; j++, k--)
                {
                    a += array[i, j];
                    b += array[j, i];
                    c += array[j, j];
                    d += array[j, k];
                }
                if (a != n)
                {
                    Console.WriteLine(">> МАТРИЦА НЕ ЯВЛЯЕТСЯ МАГИЧЕСКИМ КВАДРАТОМ (не выполняется условие строк)");
                }
                else
                {
                    if (b != n)
                    {
                        Console.WriteLine(">> МАТРИЦА НЕ ЯВЛЯЕТСЯ МАГИЧЕСКИМ КВАДРАТОМ (не выполняется условие столбцов)");
                    }
                    else
                    {
                        if (c != n && d != n)
                        {
                            Console.WriteLine(">> МАТРИЦА НЕ ЯВЛЯЕТСЯ МАГИЧЕСКИМ КВАДРАТОМ (не выполняется условие диагоналей)");
                            break;
                        }
                        else
                        {
                            if (i == m - 1)
                            {
                                Console.WriteLine(">> МАТРИЦА ЯВЛЯЕТСЯ МАГИЧЕСКИМ КВАДРАТОМ {0} = {1} = {2} = {3} = {4}", a, b, c, d, n);
                            }
                        }
                    }
                }

            }
            Console.ReadKey();
        }
    }

}
