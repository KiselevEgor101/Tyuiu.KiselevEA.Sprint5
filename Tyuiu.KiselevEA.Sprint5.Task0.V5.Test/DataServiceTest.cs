using System.IO;
using Tyuiu.KiselevEA.Sprint5.Task0.V5.Lib;
namespace Tyuiu.KiselevEA.Sprint5.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path @" D:\source\repos\Tyuiu.KiselevEA.Sprint5\Tyuiu.KiselevEA.Sprint5.Task0.V5\bin\Debug\net8.0\OutPutFileTask0.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}