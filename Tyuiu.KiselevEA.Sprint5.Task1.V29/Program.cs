using Tyuiu.KiselevEA.Sprint5.Task1.V29.Lib;
namespace Tyuiu.KiselevEA.Sprint5.Task1.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;

            DataService ds = new DataService();

            Console.WriteLine("Начальное значение диапазона = " + startValue);
            Console.WriteLine("Конечное значение диапазона = " + stopValue);

            Console.WriteLine("###########################################################################");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");

            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();

            

            
        }
    }
}
