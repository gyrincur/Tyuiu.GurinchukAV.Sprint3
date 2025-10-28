using Tyuiu.GurinchukAV.Sprint3.Task6.V30.Lib;
namespace Tyuiu.GurinchukAV.Sprint3.Task6.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = 11;
            int stopValue = 17;

            Console.WriteLine($"Начало диапазона = {startValue}");
            Console.WriteLine($"Конец диапазона = {stopValue}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int result = ds.GetSumTheDivisors(startValue, stopValue);

            Console.WriteLine($"Сумма всех делителей = {result}");
            Console.ReadKey();
        }
    }
}