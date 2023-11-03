using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VorobevSA.Sprint4.Task1.V18.Lib;

namespace Tyuiu.VorobevSA.Sprint4.Task1.V18
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
            Console.WriteLine("* Задание #4.1                                                            *");
            Console.WriteLine("* Вариант #18                                                              *");
            Console.WriteLine("* Выполнил:Воробьев Сергей Александрович | ПКТб-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 16 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 3 до 9 подсчитать сумму нечетных *");
            Console.WriteLine("* элементов с клавиатуры.{7, 6, 9, 8, 9, 7, 4, 7, 8, 5, 6, 3, 9, 7, 9, 7} *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int l;
            Console.Write("Введите коллиество элементвов массива: ");
            l = Convert.ToInt32(Console.ReadLine());

            int[] n = new int[l];

            for (int i = 0; i <= l - 1; i++)
            {
                Console.Write("Введите значение " + i+" элемент массива: ");
                n[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0; i <= l - 1; i++)
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
