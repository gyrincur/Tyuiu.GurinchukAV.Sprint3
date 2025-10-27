using Tyuiu.GurinchukAV.Sprint3.Task5.V9.Lib;
namespace Tyuiu.GurinchukAV.Sprint3.Task5.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 14;

            Console.WriteLine($"X = {x}");
            Console.WriteLine($"startValue1 = {startValue1}");
            Console.WriteLine($"stopValue1 = {stopValue1}");
            Console.WriteLine($"startValue2 = {startValue2}");
            Console.WriteLine($"stopValue2 = {stopValue2}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            Console.WriteLine($"y = {result}");
            Console.ReadKey();
        }
    }
}