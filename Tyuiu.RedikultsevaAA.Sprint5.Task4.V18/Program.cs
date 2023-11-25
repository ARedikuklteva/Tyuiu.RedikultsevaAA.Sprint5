using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Tyuiu.RedikultsevaAA.Sprint5.Task4.V18.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint5.Task4.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Редикульцева А.А. | АСОиУб 23-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #5                                                                  *");
            Console.WriteLine("* Тема: Чтение данных из текстового файлa                                    *");
            Console.WriteLine("* Задание #4                                                                 *");
            Console.WriteLine("* Вариант #18                                                                *");
            Console.WriteLine("* Выполнила: Редикульцева А.А. | АСОиУб 23-1                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Дан файл InPutDataFileTask4V18.txt (файл взять из архива согласно вашему   *");
            Console.WriteLine("* варианту. Создать папку в ручную и скопировать в неё файл) в котором есть  *");
            Console.WriteLine("* вещественное значение. Прочитать значение из файла и подставить вместо Х   *");
            Console.WriteLine("* в формуле Вычислить значение по формуле (Полученное значение округлить до  *");
            Console.WriteLine("* трёх знаков после запятой) и вернуть полученный результат на консоль.      *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V18.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
