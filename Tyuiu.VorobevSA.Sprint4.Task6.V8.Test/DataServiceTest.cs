using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VorobevSA.Sprint4.Task6.V8.Lib;

namespace Tyuiu.VorobevSA.Sprint4.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            var c = new string[] { "Пицца", "Борщ", "Пельмени", "Омлет", "Салат", "Суп", "Роллы" };
            string[] r = new service1.Calculate(c);

            Assert.AreEqual(5, r);

        }
    }
}
