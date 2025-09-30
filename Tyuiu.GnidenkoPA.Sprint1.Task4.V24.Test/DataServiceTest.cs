using Tyuiu.GnidenkoPA.Sprint1.Task4.V24.Lib;
namespace Tyuiu.GnidenkoPA.Sprint1.Task4.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidTest()
        {
            var ds = new DataService();
            double result = ds.Calculate(2, 3);
            Assert.AreEqual(0.287, result, 0.001);
        }
    }
}
