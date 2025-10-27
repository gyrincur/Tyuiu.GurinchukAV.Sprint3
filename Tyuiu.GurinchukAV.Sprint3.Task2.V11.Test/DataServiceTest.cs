using Tyuiu.GurinchukAV.Sprint3.Task2.V11.Lib;
namespace Tyuiu.GurinchukAV.Sprint3.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double value = 0.5;  
            int startValue = 1;
            int stopValue = 15;

            double result = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 0.107;  
            Assert.AreEqual(wait, result);
        }
    }
}