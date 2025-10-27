using Tyuiu.GurinchukAV.Sprint3.Task4.V21.Lib;
namespace Tyuiu.GurinchukAV.Sprint3.Task4.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = 0.586;
            Assert.AreEqual(wait, res);
        }
    }
}