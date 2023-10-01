using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShagovoyVV.Sprint0.Task4.V0.Lib;
namespace Tyuiu.ShagovoyVV.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionalValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        public void CheckSubstractValid()
        {
            Assert.AreEqual(5, DataService.Substract(10, 5));
        }

        public void CheckMuptiplicateValid()
        {
            Assert.AreEqual(50, DataService.Mplicate(10, 5));
        }

        public void CheckDivisionValid()
        {
            Assert.AreEqual(3, DataService.division(9, 3));
        }
    }
}
