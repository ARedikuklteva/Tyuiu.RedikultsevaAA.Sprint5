using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Tyuiu.RedikultsevaAA.Sprint5.Task5.V27.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint5.Task5.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Редикульцева А.А. | АСОиУб 23-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #5                                                                  *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                             *");
            Console.WriteLine("* Задание #5                                                                 *");
            Console.WriteLine("* Вариант #27                                                                *");
            Console.WriteLine("* Выполнила: Редикульцева А.А. | АСОиУб 23-1                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Дан файл InPutDataFileTask5V27.txt (файл взять из архива согласно вашему   *");
            Console.WriteLine("* варианту. Создать папку в ручную и скопировать в неё файл) в котором есть  *");
            Console.WriteLine("* набор значений. Найти среднее значение всех целых чисел в файле, которые   *");
            Console.WriteLine("* делятся на 5. Полученный результат вывести на консоль. У вещественных      *");
            Console.WriteLine("* значений округлить до трёх знаков после запятой.                           *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V27.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Среднее значение всех чисел кратных пяти = " + res);
            Console.ReadKey();
        }
    }
}
