using Tyuiu.GurinchukAV.Sprint3.Task0.V15.Lib;
namespace Tyuiu.GurinchukAV.Sprint3.Task0.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double t = 0.7;
            int startValue = 1;
            int stopValue = 10;
            double wait = 4.0632;
            double result = ds.GetSumSeries(t, startValue, stopValue);
            Assert.AreEqual(wait, result);
        }
    }
}