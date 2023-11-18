using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.RedikultsevaAA.Sprint5.Task0.V5.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint5.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistionFile()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.RedikultsevaAA.Sprint5\Tyuiu.RedikultsevaAA.Sprint5.Task0.V5\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
