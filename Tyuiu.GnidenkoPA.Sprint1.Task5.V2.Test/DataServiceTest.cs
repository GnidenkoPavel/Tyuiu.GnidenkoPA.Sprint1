using Tyuiu.GnidenkoPA.Sprint1.Task5.V2.Lib;
namespace Tyuiu.GnidenkoPA.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Fahrenheit32_To_Celsius0()
        {
            var ds = new DataService();
            int result = ds.FahrenheitToСelsius(32);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Fahrenheit212_To_Celsius100()
        {
            var ds = new DataService();
            int result = ds.FahrenheitToСelsius(212);
            Assert.AreEqual(100, result);
        }
    }
}
