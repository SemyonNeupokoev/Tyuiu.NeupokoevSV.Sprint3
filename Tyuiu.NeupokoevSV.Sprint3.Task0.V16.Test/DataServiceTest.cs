﻿using Tyuiu.NeupokoevSV.Sprint3.Task0.V16.Lib;
namespace Tyuiu.NeupokoevSV.Sprint3.Task0.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 5;
            int startValue = 1;
            int stopValue = 6;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 10220.275;
            Assert.AreEqual(wait, res);
        }
    }
}
