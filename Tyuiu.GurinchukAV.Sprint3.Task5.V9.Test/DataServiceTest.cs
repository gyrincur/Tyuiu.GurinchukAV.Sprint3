using Tyuiu.GurinchukAV.Sprint3.Task5.V9.Lib;
namespace Tyuiu.GurinchukAV.Sprint3.Task5.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 14;

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            double wait = 26.235;

            Assert.AreEqual(wait, res);
        }
    }
}