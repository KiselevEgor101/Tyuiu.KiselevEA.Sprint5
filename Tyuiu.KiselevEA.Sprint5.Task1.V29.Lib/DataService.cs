using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KiselevEA.Sprint5.Task1.V29.Lib
{
    public class DataService : ISprint5Task1V29
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string stry = string.Empty;
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask1.txt" });
           
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }
            int x;
            double y;
            
            for (x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((Math.Sin(x) / (x + 1.2)) + Math.Cos(x) * 7 * x - 2, 2);
                stry = Convert.ToString(y);
            }           
            if (x != stopValue)
            {
                File.AppendAllText(path, stry + Environment.NewLine);
            }
            else
            {
                File.AppendAllText(path, stry);
            }
            
            return path;
        }
    }
}
