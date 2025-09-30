using Tyuiu.GnidenkoPA.Sprint1.Task7.V6.Lib;
namespace Tyuiu.GnidenkoPA.Sprint1.Task7.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidTest()
        {
            var ds = new DataService();
            double result = ds.Calculate(2, 3);
            Assert.AreEqual(-142.437, result, 0.001);
        }
    }
}
