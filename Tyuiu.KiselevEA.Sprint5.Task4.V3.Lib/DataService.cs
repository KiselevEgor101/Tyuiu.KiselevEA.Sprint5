using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KiselevEA.Sprint5.Task4.V3.Lib
{
    public class DataService : ISprint5Task4V3
    {
        public double LoadFromDataFile(string path)
        {
            string x = File.ReadAllText(path);
            double res = (((Math.Sin(Convert.ToDouble(x)) + 4) / Convert.ToDouble(x)) + (1.25 * Convert.ToDouble(x)));
            res = Math.Round(res, 3);
            return res;
        }
    }
}
