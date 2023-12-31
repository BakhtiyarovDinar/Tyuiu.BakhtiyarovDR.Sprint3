﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BakhtiyarovDR.Sprint3.Task1.V25.Lib;

namespace Tyuiu.BakhtiyarovDR.Sprint3.Task1.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int value = 2;
            int startValue = 1;
            int stopValue = 6;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 1092.543;
            Assert.AreEqual(wait, res);
        }
    }
}
