using System;
using Tyuiu.GnidenkoPA.Sprint1.Task6.V15.Lib;
namespace Tyuiu.GnidenkoPA.Sprint1.Task6.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Гниденко П. А. | ПИНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс Strings                                                      *");
            Console.WriteLine("* Задание #6                                                             *");
            Console.WriteLine("* Вариант #15                                                          *");
            Console.WriteLine("* Выполнил: Гниденко П. А. | ПИНб-25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что в строке больше букв, чем знаков.             *");
            Console.WriteLine("* и печатает результат на экране.                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что в строке больше букв, чем знаков.                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            bool result = ds.CheckLettersCount(text);

            Console.WriteLine($"Букв больше чем знаков: {result}");
        }
    }
}
