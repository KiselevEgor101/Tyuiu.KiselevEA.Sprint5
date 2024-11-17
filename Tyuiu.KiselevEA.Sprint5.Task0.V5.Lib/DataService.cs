using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KiselevEA.Sprint5.Task0.V5.Lib
{
    public class DataService : ISprint5Task0V5
    {
        public string SaveToFileTextData(int x)
        {
            string s = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask0.txt" });

            double res = Math.Log(((double)x + 1) / ((double)x + 2));

            res = Math.Round(res, 3);

            File.WriteAllText(s, Convert.ToString(res));

            return s;
        }
    }
}
