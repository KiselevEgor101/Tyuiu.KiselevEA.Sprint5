using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KiselevEA.Sprint5.Task0.V5.Lib
{
    public class DataService : ISprint5Task0V5
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";

            double res = Math.Log((x + 1) / (x + 2));

            res = Math.Round(res, 3);

            File.WriteAllText(path, Convert.ToString(res));

            return path;
        }
    }
}
