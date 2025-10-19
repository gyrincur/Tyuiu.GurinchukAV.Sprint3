using Tyuiu.GurinchukAV.Sprint3.Task0.V15.Lib;
namespace Tyulu.GurinchukAV.Sprint3.Task0.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            double t = 0.7;
            int startValue = 1;
            int stopValue = 10;

            Console.WriteLine($"Значение t = {t}");
            Console.WriteLine($"Стартовое значение k = {startValue}");
            Console.WriteLine($"Конечное значение k = {stopValue}");

            Console.WriteLine();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("**************************************************************************");

            DataService ds = new DataService();
            double result = ds.GetSumSeries(t, startValue, stopValue);

            Console.WriteLine($"Сумма ряда S = {result:F4}");
            Console.ReadKey();
        }
    }
}
