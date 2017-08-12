using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCalc.Test
{
    [TestClass]
    public class MyCalcTests
    {
        [TestMethod]
        public void Sum_10and20_30returned()
        {
            //arrange
            int x = 10;
            int y = 20;
            int expected = 30;

            //act
            Calc c = new Calc();
            int actual = c.Sum(x, y);

            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}
