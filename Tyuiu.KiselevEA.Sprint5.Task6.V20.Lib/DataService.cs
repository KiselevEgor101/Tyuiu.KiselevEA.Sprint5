using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KiselevEA.Sprint5.Task6.V20.Lib
{
    public class DataService : ISprint5Task6V20
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            int a = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == ' ')
                        {
                            if (a == 6) count++;
                            a = 0;
                        }
                        else
                        {
                            a++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
