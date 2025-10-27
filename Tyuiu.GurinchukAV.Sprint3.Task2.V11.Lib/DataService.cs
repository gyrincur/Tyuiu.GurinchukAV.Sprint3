using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GurinchukAV.Sprint3.Task2.V11.Lib
{
    public class DataService : ISprint3Task2V11
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i = startValue;
            do
            {
                double denominator = 3 + Math.Pow(value, i);  
                double term = Math.Pow(1 / denominator, i);
                sumSeries += term;
                i++;
            }
            while (i <= stopValue);
            return Math.Round(sumSeries, 3);
        }
    }
}