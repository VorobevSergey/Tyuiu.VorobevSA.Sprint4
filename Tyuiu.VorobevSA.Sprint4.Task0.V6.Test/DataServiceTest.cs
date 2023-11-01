using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VorobevSA.Sprint4.Task0.V6.Lib;

namespace Tyuiu.VorobevSA.Sprint4.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            int[] i = { 1, 6, 3, 7, 5, 4, 2, 7, 8, 9 };
            int res = service1.GetSumOddArrEl(i);
            int walie = 32;
            Assert.AreEqual(walie, res);
        }
    }
}
