using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GnidenkoPA.Sprint1.Task7.V6.Lib
{
    public class DataService : ISprint1Task7V6
    {
        public double Calculate(double x, double y)
        {
            double part1 = Math.Pow(1 + 1 / (x * x), x);
            double part2 = 12 * x * x * y;
            double result = part1 - part2;

            return Math.Round(result, 3);
        }
    }
}
