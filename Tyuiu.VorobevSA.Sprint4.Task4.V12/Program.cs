using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VorobevSA.Sprint4.Task4.V12.Lib;

namespace Tyuiu.VorobevSA.Sprint4.Task4.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Воробьев С.А. | ПКДб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:Оператор цикла continue/break                                      *");
            Console.WriteLine("* Задание #4.4                                                            *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил:Воробьев Сергей Александрович | ПКТб-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* случайными значениями в диапазоне от -6 до 4. Найти количество          *");
            Console.WriteLine("* отрицательных элементов.                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService service1 = new DataService();

            Console.Write("Введите колличество строк массива: ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите колличество столбцов: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int[,] m = new int[r, c];

            Console.WriteLine("***************************************************************************");

            for (int i=0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write($"Введите{i},{j}элемент массива");
                    m[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nМассив");
            for (int i = 0; i < r; i++)
            {
                for(int j = 0; j < c; j++)
                {
                    Console.Write($"{m[i, j]}\t");
                }
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = service1.Calculate(m);

            Console.WriteLine("кол-во отриц элем=" + res);

            Console.ReadKey();
        }
    }
}
