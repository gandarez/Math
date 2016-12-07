using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdjacentPointsMaxDistance.Tests
{
    [TestClass]
    public class AdjacentPointsMinDistanceUsingLinqTest
    {
        [TestMethod]
        public void WhenInputArrayWithMinDistance1_Calcule_ThenReturn1()
        {
            var actual = new MinDistanceUsingLinq().Calculate(new[] { 0, 3, 12, 5, 7, 1 });
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void WhenInputArrayIsGreaterThan40000_Calculate_ThenReturnMinus2()
        {
            new MinDistanceUsingLinq().Calculate(new int[40001]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void WhenInputArrayIsNull_Calculate_ThenReturnMinus2()
        {
            new MinDistanceUsingLinq().Calculate(null);
        }
    }
}