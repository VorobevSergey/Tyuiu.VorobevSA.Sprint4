using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VorobevSA.Sprint4.Task6.V8.Lib;

namespace Tyuiu.VorobevSA.Sprint4.Task6.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Воробьев С.А. | ПКДб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:Оператор цикла continue/break                                      *");
            Console.WriteLine("* Задание #4.5                                                            *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил:Воробьев Сергей Александрович | ПКТб-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных используя класс Array, выведите элементы    *");
            Console.WriteLine("* массива, длина которых больше 4 символов.                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService service1 = new DataService();

            var c = new string[] { "Пицца", "Борщ", "Пельмени", "Омлет", "Салат", "Суп", "Роллы" };

            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i <= c.Length - 1; i++)
            {

                Console.WriteLine(c[i]);
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Массив новый ");
            

            Console.ReadKey();
        }
    }
}
