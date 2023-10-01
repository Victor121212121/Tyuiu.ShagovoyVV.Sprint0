using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShagovoyVV.Sprint0.Task6.V0.Lib;

namespace Tyuiu.ShagovoyVV.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArrayValid()
        {
            var numbs = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(numbs);
            Assert.AreEqual(15, res);
        }

        [TestMethod]
        public void CheckSubArrayValid()
        {
            var numbs = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubStrArray(numbs);
            Assert.AreEqual(-15, res);
        }

        [TestMethod]
        public void CheckMultArrayValid()
        {
            var numbs = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultPlArray(numbs);
            Assert.AreEqual(120, res);
        }
    }
}
