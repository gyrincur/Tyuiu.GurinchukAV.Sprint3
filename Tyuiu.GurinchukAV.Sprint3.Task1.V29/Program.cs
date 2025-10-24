using Tyuiu.GurinchukAV.Sprint3.Task1.V29.Lib;
namespace Tyuiu.GurinchukAV.Sprint3.Task1.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            double x = 0.25;
            int startValue = 1;
            int stopValue = 11;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Значение X = {x}");
            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.GetMultiplySeries(x, startValue, stopValue);
            Console.WriteLine($"Произведение ряда = {result}");

            Console.ReadKey();
        }
    }
}
