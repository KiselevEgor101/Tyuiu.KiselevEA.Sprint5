using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.KiselevEA.Sprint5.Task7.V19.Lib
{
    public class DataService : ISprint5Task7V19
    {
        public string LoadDataAndSave(string path)
        {
            string pathsave = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask7.txt" });

            FileInfo fileInfo = new FileInfo(pathsave);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathsave);
            }
            //код для числовых выражение
            //string strline = "";
            //using(StreamReader reader = new StreamReader(path))
            //{
                //string line;
                //while ((line = reader.ReadLine()) != null)
                //{
                //for (int i = 0; i < line.Length; i++)
                //{
                   //if ((line[i] != 'сс') && (line[i] != 'С'))
                   //{
                     //strline += line[i];
                   //}
                //}

            //File.AppendAllText(pathsave, strline + Environment.NewLine);
            //strline = "";

                //}
            //}
            //return pathsave;


            
            string basefile = File.ReadAllText(path);

            string cond = basefile.Replace("сс", "").Replace("Сс","");


            File.WriteAllText(pathsave, cond);
            return pathsave;
        }
    }
}
