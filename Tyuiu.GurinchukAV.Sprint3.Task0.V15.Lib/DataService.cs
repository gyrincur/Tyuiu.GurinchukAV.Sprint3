using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GurinchukAV.Sprint3.Task0.V15.Lib
{
    public class DataService : ISprint3Task0V15
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;

            for (int k = startValue; k <= stopValue; k++)
            {
                double term = (Math.Pow(value, k) + (2.0 / (k + 1))) * Math.Sin(value);
                sumSeries += term;
            }

            return Math.Round(sumSeries, 3);

        }
    }
}