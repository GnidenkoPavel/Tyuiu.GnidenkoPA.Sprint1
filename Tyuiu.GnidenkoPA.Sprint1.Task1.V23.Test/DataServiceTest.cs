using Tyuiu.GnidenkoPA.Sprint1.Task1.V23.Lib;
namespace Tyuiu.GnidenkoPA.Sprint1.Task1.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidTest()
        {
            var ds = new DataService();
            double result = ds.Calculate(1, 2);
            // (2 * π) / (2 * 1) = π ≈ 3.14159
            Assert.AreEqual(Math.PI, result, 0.001);
        }
    }
}
