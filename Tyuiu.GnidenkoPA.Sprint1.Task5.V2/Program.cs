using System;
using Tyuiu.GnidenkoPA.Sprint1.Task5.V2.Lib;
namespace Tyuiu.GnidenkoPA.Task5.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Гниденко П. А. | ПИНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Class Math                                                        *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #2                                                            *");
            Console.WriteLine("* Выполнил: Гниденко П. А. | ПИНб-25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:\r\n\r\nДано значение температуры в градусах Фаренгейта. Определить значение этой же температуры в градусах Цельсия. Ответ привести к целому с помощью класса Convert.             *");
            Console.WriteLine("* и печатает результат на экране.                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:\r\n\r\nДано значение температуры в градусах Фаренгейта. Определить значение этой же температуры в градусах Цельсия. Ответ привести к целому с помощью класса Convert.                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите температуру в градусах Фаренгейта:");
            double fahrenheit = double.Parse(Console.ReadLine());

            int celsius = ds.FahrenheitToСelsius(fahrenheit);

            Console.WriteLine($"Температура в градусах Цельсия: {celsius}°C");
        }
    }
}