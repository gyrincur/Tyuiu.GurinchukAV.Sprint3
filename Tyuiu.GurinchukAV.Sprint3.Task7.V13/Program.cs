using Tyuiu.GurinchukAV.Sprint3.Task7.V13.Lib;
namespace Tyuiu.GurinchukAV.Sprint3.Task7.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Начало диапазона = {startValue}");
            Console.WriteLine($"Конец диапазона = {stopValue}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("+----------+-----------+");
            Console.WriteLine("|    X     |    f(x)   |");
            Console.WriteLine("+----------+-----------+");

            int x = startValue;
            for (int i = 0; i < res.Length; i++, x++)
            {
                Console.WriteLine("|{0,5:d}     |  {1,6:f2}   |", x, res[i]);
            }

            Console.WriteLine("+----------+-----------+");
            Console.ReadKey();
        }
    }
}
