using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BakhtiyarovDR.Sprint3.Task6.V19.Lib;

namespace Tyuiu.BakhtiyarovDR.Sprint3.Task6.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            Assert.AreEqual(16, service1.GetSumTheDivisors(10, 15));
        }
    }
}
