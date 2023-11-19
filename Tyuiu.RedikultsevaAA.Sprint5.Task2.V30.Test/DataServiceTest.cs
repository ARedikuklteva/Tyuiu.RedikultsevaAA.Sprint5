using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.RedikultsevaAA.Sprint5.Task2.V30.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint5.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistionsFile()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.RedikultsevaAA.Sprint5\Tyuiu.RedikultsevaAA.Sprint5.Task2.V30\bin\Debug\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
