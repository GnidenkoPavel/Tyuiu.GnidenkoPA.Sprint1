using System;
using Tyuiu.GnidenkoPA.Sprint1.Task7.V6.Lib;
namespace Tyuiu.GnidenkoPA.Sprint1.Task7.V6
{
    internal class Program
    {
        public static void Main()
        {
            var ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Гниденко П. А. | ПИНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                                                    *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #6                                                           *");
            Console.WriteLine("* Выполнил: Гниденко П. А. | ПИНб-25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по исходным значениям данных, вводимых пользователем. Ответ округлите до 3 знаков после запятой.             *");
            Console.WriteLine("* и печатает результат на экране.                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по исходным значениям данных, вводимых пользователем. Ответ округлите до 3 знаков после запятой.                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите x:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите y:");
            double y = double.Parse(Console.ReadLine());

            double result = ds.Calculate(x, y);

            Console.WriteLine($"Результат: z = {result}");
        }
    }
}
