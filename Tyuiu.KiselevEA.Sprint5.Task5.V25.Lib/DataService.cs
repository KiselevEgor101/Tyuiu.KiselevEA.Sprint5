using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KiselevEA.Sprint5.Task5.V25.Lib
{
    public class DataService : ISprint5Task5V25
    {
        public double LoadFromDataFile(string path)
        {
            double res = 1;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Разделение строки на части
                    string[] numbers = line.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string number in numbers)
                    {
                        if (double.TryParse(number, out double value))
                        {
                            res *= value; // Умножаем на каждое значение
                        }
                        else
                        {
                            // Обработка некорректного формата
                            Console.WriteLine($"Некорректное значение: {number}");
                        }
                    }
                }
            }
            return res;
        }
    }
}
