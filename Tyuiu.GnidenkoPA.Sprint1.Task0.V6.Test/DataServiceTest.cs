using Tyuiu.GnidenkoPA.Sprint1.Task0.V6.Lib;
namespace Tyuiu.GnidenkoPA.Sprint1.Task0.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(15, res);
        }
    }
}
