using System;
using Tyuiu.GnidenkoPA.Sprint1.Task1.V23.Lib;
namespace Tyuiu.GnidenkoPA.Sprint1.Task1.V23
{
    internal class Program
    {
        public static void Main()
        {
            var ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Гниденко П. А. | ПИНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #23                                                               *");
            Console.WriteLine("* Выполнил: Гниденко П. А. | ПИНб-25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, вычисляет результат по формуле (x*Pi)/(2*a) и печатает его на экране.             *");
            Console.WriteLine("* и печатает результат на экране.                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, вычисляет результат по формуле (x*Pi)/(2*a) и печатает его на экране.                                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите x:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите a:");
            double a = double.Parse(Console.ReadLine());

            double result = ds.Calculate(a, x);

            Console.WriteLine($"Результат: {result}");
        }
    }
}
