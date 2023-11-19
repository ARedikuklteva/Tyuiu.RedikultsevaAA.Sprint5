using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RedikultsevaAA.Sprint5.Task1.V30.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint5.Task1.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Редикульцева А.А. | АСОиУб 23-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #5                                                                  *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                    *");
            Console.WriteLine("* Задание #1                                                                 *");
            Console.WriteLine("* Вариант #30                                                                *");
            Console.WriteLine("* Выполнила: Редикульцева А.А. | АСОиУб 23-1                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("*                               sin(x)                                       *");
            Console.WriteLine("* Дана фунция, F(x) = cos(x) + -------- - 4x (произвести табулирование) f(x) *");
            Console.WriteLine("*                               2 - 2x                                       *");
            Console.WriteLine("* на заднном диапозоне [-5;5] с шагом 1. Произвести проверку деления на ноль.*");
            Console.WriteLine("* При делении на ноль вернуть значение 0. Результат сохранить в текстовый    *");
            Console.WriteLine("* файл OutPutFileTask1.txt и вывести на консоль в таблицу. Значения          *");
            Console.WriteLine("* округлить до двух знаков после запятой.                                    *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
