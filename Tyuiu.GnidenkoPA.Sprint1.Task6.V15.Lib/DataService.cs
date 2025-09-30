using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GnidenkoPA.Sprint1.Task6.V15.Lib
{
    public class DataService : ISprint1Task6V15
    {
        public bool CheckLettersCount(string value)
        {
            if (string.IsNullOrEmpty(value))
                return false;

            int letterCount = value.Count(char.IsLetter);
            int symbolCount = value.Count(c => !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c));

            return letterCount > symbolCount;
        }
    }
}
