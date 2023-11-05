using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VorobevSA.Sprint4.Task3.V9.Lib;

namespace Tyuiu.VorobevSA.Sprint4.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            int[,] q = new int[5, 5] { { 9, 6, 4, 5, 3 },
                                     { 7,4,7,5,3},
                                     { 8,5,5,9,3},
                                     { 7,8,7,9,3},
                                     { 3,7,3,7,7} };
            int res = service1.Calculate(q);
            Assert.AreEqual(20, res);
        }
    }
}
