﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BakhtiyarovDR.Sprint3.Task4.V24.Lib;

namespace Tyuiu.BakhtiyarovDR.Sprint3.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            Assert.AreEqual(46.750, res);
        }
    }
}
