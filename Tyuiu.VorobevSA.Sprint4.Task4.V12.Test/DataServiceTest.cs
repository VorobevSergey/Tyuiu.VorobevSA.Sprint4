using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VorobevSA.Sprint4.Task4.V12.Lib;

namespace Tyuiu.VorobevSA.Sprint4.Task4.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            int[,] q = new int[5, 5] 
            {
            {4, 3, 2, 4, 5},
            {5, 4, 5, 6, 6 },
            {6, 2, 3, 6, 5 },
            {6, 2, 3, 6, 4 },
            {6, 2, 6, 6, 2 }
            };
            
            int[,] r = service1.Calculate(q);

            int[,] w = new int[5, 5]
            {
            {4, 0, 2, 4, 0},
            {0, 4, 0, 6, 6 },
            {6, 2, 0, 6, 0 },
            {6, 2, 0, 6, 4 },
            {6, 2, 6, 6, 2 }
            };
            Assert.AreEqual(w, r);
        }
    }
}
