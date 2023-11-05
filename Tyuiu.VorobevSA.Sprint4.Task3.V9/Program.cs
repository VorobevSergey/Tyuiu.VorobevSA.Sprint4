using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VorobevSA.Sprint4.Task3.V9.Lib;

namespace Tyuiu.VorobevSA.Sprint4.Task3.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService service1 = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Воробьев С.А. | ПКДб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:Оператор цикла continue/break                                      *");
            Console.WriteLine("* Задание #4.3                                                            *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил:Воробьев Сергей Александрович | ПКТб-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов заполненный         *");
            Console.WriteLine("* случайными в диапазоне от 2 до 9 подсчитать сумму нечетных элементов    *");
            Console.WriteLine("* массива.                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] q = new int[5, 5] { { 9, 6, 4, 5, 3 },
                                     { 7,4,7,5,3},
                                     { 8,5,5,9,3},
                                     { 7,8,7,9,3},
                                     { 3,7,3,7,7} };
            int rows = q.GetUpperBound(0) + 1;
            int colums = q.Length / rows;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Массив: ");
            int y = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{q[i, j]} \t");
                }
            }
            int res = service1.Calculate(q);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Ответ " + res);


            Console.ReadKey();
        }
    }
}
