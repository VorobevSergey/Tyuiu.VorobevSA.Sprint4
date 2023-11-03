using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VorobevSA.Sprint4.Task1.V18.Lib;

namespace Tyuiu.VorobevSA.Sprint4.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            int[] i = { 7,6,9,8,9,7,4,7,8,5,6,3,9,7,9,7 };
            int res = service1.Calculate(i);
            int walie = 79;
            Assert.AreEqual(walie, res);
        }
    }
}
