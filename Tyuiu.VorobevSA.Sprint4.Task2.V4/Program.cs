using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VorobevSA.Sprint4.Task2.V4.Lib;

namespace Tyuiu.VorobevSA.Sprint4.Task2.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService service1 = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Воробьев С.А. | ПКДб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:Оператор цикла continue/break                                      *");
            Console.WriteLine("* Задание #4.2                                                            *");
            Console.WriteLine("* Вариант #4                                                               *");
            Console.WriteLine("* Выполнил:Воробьев Сергей Александрович | ПКТб-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов заполненный         *");
            Console.WriteLine("* случайными в диапазоне от 2 до 9 подсчитать сумму нечетных элементов    *");
            Console.WriteLine("* массива.                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите коллиество элементвов массива: ");
            int l = Convert.ToInt32(Console.ReadLine());

            int[] n = new int[l];

            for (int i = 0; i <= l - 1; i++)
            {
                n[i] = rnd.Next(2, 9);
            }

            Console.WriteLine("Массив: ");
            for (int i = 0; i <= l - 1; i++)
            {
                Console.Write(n[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = service1.Calculate(n);
            Console.WriteLine("Сумма нечетных чисел в массиве= " + res);

            Console.ReadKey();
        }
    }
}
