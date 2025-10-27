using Tyuiu.GurinchukAV.Sprint3.Task2.V11.Lib;
namespace Tyuiu.GurinchukAV.Sprint3.Task2.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double value = 0.5;
            int startValue = 1;
            int stopValue = 15;

            Console.WriteLine($"Значение X = {value}");
            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            double result = ds.GetSumSeries(value, startValue, stopValue);

            Console.WriteLine($"Сумма ряда S = {result}");
            Console.ReadKey();
        }
    }
}