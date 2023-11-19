using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.RedikultsevaAA.Sprint5.Task1.V30.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint5.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.RedikultsevaAA.Sprint5\Tyuiu.RedikultsevaAA.Sprint5.Task1.V30\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
