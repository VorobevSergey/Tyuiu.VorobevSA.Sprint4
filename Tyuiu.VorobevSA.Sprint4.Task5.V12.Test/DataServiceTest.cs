using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VorobevSA.Sprint4.Task5.V12.Lib;

namespace Tyuiu.VorobevSA.Sprint4.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            int[,] q = new int[5, 5] { { 4,3,2,1,0},
                                     { -1,0,1,2,3},
                                     { -6,-5,-4,-3,-2},
                                     { -1,-2,-3,-4,-5},
                                     { 4,3,2,1,0} };
            int res = service1.Calculate(q);
            Assert.AreEqual(12, res);
        }
    }
}
