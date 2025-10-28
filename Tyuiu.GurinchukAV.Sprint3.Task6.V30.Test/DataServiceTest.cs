using Tyuiu.GurinchukAV.Sprint3.Task6.V30.Lib;
namespace Tyuiu.GurinchukAV.Sprint3.Task6.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 11;
            int stopValue = 17;

            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 25; 
            Assert.AreEqual(wait, res);
        }
    }
}