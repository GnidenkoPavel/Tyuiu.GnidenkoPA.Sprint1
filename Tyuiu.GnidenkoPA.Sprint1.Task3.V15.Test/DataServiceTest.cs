using Tyuiu.GnidenkoPA.Sprint1.Task3.V15.Lib;
namespace Tyuiu.GnidenkoPA.Sprint1.Task3.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidTest()
        {
            var ds = new DataService();
            double result = ds.DistanceOverTime(60, 80, 5, 7);
            Assert.AreEqual(985, result);
        }
    }
}
