using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VorobevSA.Sprint4.Task7.V11.Lib;

namespace Tyuiu.VorobevSA.Sprint4.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int r = 4;
            int c = 2;
            int[,] m = new int[r, c];
            string str = "56789012";
            DataService s = new DataService();
            int res = s.Calculate(r, c, str);
            Assert.AreEqual(5, res);
        }
    }
}
