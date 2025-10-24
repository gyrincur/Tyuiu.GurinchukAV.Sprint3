using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GurinchukAV.Sprint3.Task1.V29.Lib
{
    public class DataService : ISprint3Task1V29
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double multiplySeries = 1;

            while (startValue <= stopValue)
            {
                multiplySeries *= (Math.Pow(value, 2) * startValue) + 2;
                startValue++;
            }

            return Math.Round(multiplySeries, 3);
        }
    }
}
