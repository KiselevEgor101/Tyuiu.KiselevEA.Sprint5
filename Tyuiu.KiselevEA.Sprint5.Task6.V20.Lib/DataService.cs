using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KiselevEA.Sprint5.Task6.V20.Lib
{
    public class DataService : ISprint5Task6V20
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    
                    var words = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                    
                    count += words.Count(word => word.Length == 6);
                }
            }

            return count;
        }
    }
}
