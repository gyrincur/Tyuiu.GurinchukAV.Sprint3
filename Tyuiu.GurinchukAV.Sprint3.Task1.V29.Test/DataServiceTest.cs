using Tyuiu.GurinchukAV.Sprint3.Task1.V29.Lib;
namespace Tyuiu.GurinchukAV.Sprint3.Task1.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            double value = 0.25;
            int startValue = 1;
            int stopValue = 11;

            double wait = 13051.34;
            double result = ds.GetMultiplySeries(value, startValue, stopValue);

            Assert.AreEqual(wait, result);
        }
    }
}