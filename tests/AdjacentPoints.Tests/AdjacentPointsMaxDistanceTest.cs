using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdjacentPointsMaxDistance.Tests
{
    [TestClass]
    public class AdjacentPointsMaxDistanceTest
    {
        [TestMethod]
        public void WhenInputArrayWithMaxDistance5_Calcule_ThenReturn5()
        {
            var actual = new MaxDistance().Calculate(new[] { 0, 3, 3, 12, 5, 3, 7, 1 });
            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        public void WhenInputArrayWithMaxDistance4_Calcule_ThenReturn4()
        {
            var actual = new MaxDistance().Calculate(new[] { 1, 1, 4, 5, 8, 2, 12 });
            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void WhenInputArrayWithMaxDistance82_Calcule_ThenReturn82()
        {
            var actual = new MaxDistance().Calculate(new[] { 1, 1, 4, 17, 99 });
            Assert.AreEqual(82, actual);
        }

        [TestMethod]
        public void WhenInputArrayWithMaxDistance10_Calcule_ThenReturn10()
        {
            var actual = new MaxDistance().Calculate(new[] { -3, -5, 8, -2, 12 });
            Assert.AreEqual(10, actual);
        }

        [TestMethod]
        public void WhenInputArrayHasAllPositiveNumbers_Calcule_ThenReturnMinus2()
        {
            var actual = new MaxDistance().Calculate(new[] { 1, 1, 1, 1 });
            Assert.AreEqual(-2, actual);
        }

        [TestMethod]
        public void WhenInputArrayHasAllNegativeNumbers_Calcule_ThenReturnMinus2()
        {
            var actual = new MaxDistance().Calculate(new[] { -5, -5, -5 });
            Assert.AreEqual(-2, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void WhenInputArrayIsEmpty_Calculate_ThenReturnMinus2()
        {
            new MaxDistance().Calculate(new int[] { });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void WhenInputArrayIsGreaterThan40000_Calculate_ThenReturnMinus2()
        {
            new MaxDistance().Calculate(new int[40001]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void WhenInputArrayIsNull_Calculate_ThenReturnMinus2()
        {
            new MaxDistance().Calculate(null);
        }
    }
}
