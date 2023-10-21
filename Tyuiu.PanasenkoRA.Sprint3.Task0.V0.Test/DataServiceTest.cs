using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PanasenkoRA.Sprint3.Task0.V0.Lib;

namespace Tyuiu.PanasenkoRA.Sprint3.Task0.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 20;
            double res = ds.GetMultiplySeries(startValue, stopValue);
            double wait = 37.378;
            Assert.AreEqual(wait, res);
        }
    }
}
