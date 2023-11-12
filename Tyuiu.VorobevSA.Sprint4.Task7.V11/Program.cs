using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VorobevSA.Sprint4.Task7.V11.Lib;

namespace Tyuiu.VorobevSA.Sprint4.Task7.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Воробьев С.А. | ПКДб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:Оператор цикла continue/break                                      *");
            Console.WriteLine("* Задание #4.7                                                            *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил:Воробьев Сергей Александрович | ПКТб-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 56789012. Преобразуйте ее в           *");
            Console.WriteLine("* матрицу 4 на 2 и подсчитайте количество нечетных чисел в матрице.       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService service1 = new DataService();

            int rows = 4;
            int columns = 2;
            int[,] mtrx = new int[rows, columns];

            string str = "56789012";

            int index = 0;

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = service1.Calculate(rows, columns, str);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
