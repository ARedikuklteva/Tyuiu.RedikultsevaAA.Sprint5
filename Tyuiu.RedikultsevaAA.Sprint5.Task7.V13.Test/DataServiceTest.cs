using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.RedikultsevaAA.Sprint5.Task7.V13.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint5.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistionsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V13.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
