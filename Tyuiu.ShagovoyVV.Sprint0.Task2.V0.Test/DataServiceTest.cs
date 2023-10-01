using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShagovoyVV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.ShagovoyVV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataSerivceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Виктор";
            var res = DataSerivce.GetMessage(name);

            Assert.AreEqual("Привет, Виктор", res);
        }
    }
}
