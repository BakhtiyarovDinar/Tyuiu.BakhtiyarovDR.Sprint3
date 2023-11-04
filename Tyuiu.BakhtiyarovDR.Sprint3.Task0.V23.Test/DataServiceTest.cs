using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BakhtiyarovDR.Sprint3.Task0.V23.Lib;

namespace Tyuiu.BakhtiyarovDR.Sprint3.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double value = 1.5;
            int startValue = 1;
            int stopValue = 10;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 0.298;
            Assert.AreEqual(res, wait);
        }
    }
}
