using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VorobevSA.Sprint4.Task0.V6.Lib;

namespace Tyuiu.VorobevSA.Sprint4.Task0.V6
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
            Console.WriteLine("* Задание #4.0                                                            *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил:Воробьев Сергей Александрович | ПКТб-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать сумму нечетных *");
            Console.WriteLine("* элементов массива.  {1 ,6 ,3 ,7 ,5 ,4 ,2 ,7 ,8 ,9}                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] q = { 1, 6, 3, 7, 5, 4, 2, 7, 8, 9 };

            Console.WriteLine("Исходный массив" );
            for (int i = 0; i <= q.Length - 1; i++)
            {
                Console.WriteLine(q[i] + "\t");
            }
            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = service1.GetSumOddArrEl(q);
            Console.WriteLine("Сумма нечетных чисел в массиве= " + res);
            
            Console.ReadKey();
        }
    }
}
