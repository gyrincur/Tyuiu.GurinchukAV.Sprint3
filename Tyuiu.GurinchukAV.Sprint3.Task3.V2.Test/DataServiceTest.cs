using Tyuiu.GurinchukAV.Sprint3.Task3.V2.Lib;
namespace Tyuiu.GurinchukAV.Sprint3.Task3.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMaxCharCount()
        {
            DataService ds = new DataService();
            string value = "asdzzz vfvfzz v gthvz";
            char item = 'z';

            int result = ds.GetMaxCharCount(value, item);
            int wait = 3;

            Assert.AreEqual(wait, result);
        }
    }
}