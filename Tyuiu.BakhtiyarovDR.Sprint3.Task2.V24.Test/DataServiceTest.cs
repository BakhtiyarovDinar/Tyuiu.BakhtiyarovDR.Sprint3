using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BakhtiyarovDR.Sprint3.Task2.V24.Lib;

namespace Tyuiu.BakhtiyarovDR.Sprint3.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMultiplySeries()
        {
            DataService ds = new DataService();

            double value = 0.25;
            int startValue = 1;
            int stopValue = 8;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 55217.446;
            Assert.AreEqual(wait, res);
        }
    }
}
