using Microsoft.VisualStudio.TestPlatform.TestHost;
using Tyuiu.GnidenkoPA.Sprint1.Task2.V19.Lib;
namespace Tyuiu.GnidenkoPA.Sprint1.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ConvertInchToKm_10_Return0_254()
        {
            var ds = new DataService();
            double result = ds.ConvertInchToKm(10);
            Assert.AreEqual(0.254, result, 0.001);
        }
        [TestMethod]
        public void ConvertInchToKm_100_Return2_54()
        {
            var ds = new DataService();
            double result = ds.ConvertInchToKm(100);
            Assert.AreEqual(2.54, result, 0.001);
        }
    }
}
