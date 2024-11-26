using Tyuiu.KiselevEA.Sprint5.Task7.V19.Lib;
namespace Tyuiu.KiselevEA.Sprint5.Task7.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Киселев Е. А. | СМАРТб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Киселев Егор Алексеевич | СМАРТб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Удалить все удвоенные буквы \"сс\" из файла.                            *");
            Console.WriteLine("* Полученный результат сохранить в файл.                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine(new string[] { Path.GetTempPath(), "InPutDataFileTask7V19.txt" });
            string pathsave = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask7.txt" });



            DataService ds = new DataService();


            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ В ФАЙЛЕ: " + path);



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            pathsave = ds.LoadDataAndSave(path);

            Console.WriteLine("Итоговый ответ хранится в файле: " + pathsave);
            
            Console.ReadKey();
        }
    }
}
