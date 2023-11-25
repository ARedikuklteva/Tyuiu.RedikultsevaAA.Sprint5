using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RedikultsevaAA.Sprint5.Task4.V18.Lib
{
    public class DataService : ISprint5Task4V18
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double x = Convert.ToDouble(strX);
            double res = Math.Round((Math.Cos(x) + Math.Pow(x, 2)/2), 3);
            return res;
        }
    }
}
