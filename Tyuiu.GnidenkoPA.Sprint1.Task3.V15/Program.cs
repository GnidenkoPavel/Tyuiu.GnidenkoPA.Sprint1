using System;
using Tyuiu.GnidenkoPA.Sprint1.Task3.V15.Lib;
namespace Tyuiu.GnidenkoPA.Sprint1.Task3.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Гниденко П. А. | ПИНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                    *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                              *");
            Console.WriteLine("* Выполнил: Гниденко П. А. | ПИНб-25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("* и печатает результат на экране.                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Написать программу, решающую следующую задачу: два автомобиля имеют скорости V1 км/ч и V2 км/ч соответственно, находятся на расстоянии S км друг от друга и движутся в противоположные стороны. Определить расстояние между ними через T часов. Ответ округлите до 3 знаков после запятой.                                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите скорость первого автомобиля (км/ч):");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите скорость второго автомобиля (км/ч):");
            double v2 = double.Parse(Console.ReadLine());

            double S = 5;
            double T = 7;

            double distance = ds.DistanceOverTime(v1, v2, S, T);

            Console.WriteLine($"Расстояние через {T} часов: {distance} км");
        }
    }
}
