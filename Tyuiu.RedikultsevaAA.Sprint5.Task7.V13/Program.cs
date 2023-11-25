using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Tyuiu.RedikultsevaAA.Sprint5.Task7.V13.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint5.Task7.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Редикульцева А.А. | АСОиУб 23-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #5                                                                  *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                    *");
            Console.WriteLine("* Задание #7                                                                 *");
            Console.WriteLine("* Вариант #13                                                                *");
            Console.WriteLine("* Выполнила: Редикульцева А.А. | АСОиУб 23-1                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Дан файл InPutDataFileTask6V27.txt (файл взять из архива согласно вашему   *");
            Console.WriteLine("* варианту. Создать папку в ручную и скопировать в неё файл) в котором есть  *");
            Console.WriteLine("* символьных данных.Удалить все строчные латинские буквы из файла.           *");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V13.txt.          *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V13.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V13.txt";

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine("Находится в файле:");
            Console.WriteLine(pathSaveFile);
            Console.ReadKey();
        }
    }
}
