using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.RedikultsevaAA.Sprint5.Task4.V18.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint5.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistionsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V18.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
