using Tyuiu.GurinchukAV.Sprint3.Task3.V2.Lib;
namespace Tyuiu.GurinchukAV.Sprint3.Task3.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "asdzzz vfvfzz v gthvz";
            char item = 'z';

            Console.WriteLine($"Строка: {value}");
            Console.WriteLine($"Искомый символ: {item}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int result = ds.GetMaxCharCount(value, item);

            Console.WriteLine($"Максимальное количество подряд идущих символов '{item}' = {result}");
            Console.ReadKey();
        }
    }
}