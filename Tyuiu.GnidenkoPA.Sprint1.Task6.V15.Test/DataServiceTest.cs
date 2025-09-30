using Tyuiu.GnidenkoPA.Sprint1.Task6.V15.Lib;
namespace Tyuiu.GnidenkoPA.Sprint1.Task6.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void MoreLetters_ReturnTrue()
        {
            var ds = new DataService();
            bool result = ds.CheckLettersCount("Hello World!");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void MoreSymbols_ReturnFalse()
        {
            var ds = new DataService();
            bool result = ds.CheckLettersCount("!!! ???");
            Assert.IsFalse(result);
        }
    }
}
