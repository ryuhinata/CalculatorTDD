using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace CalculatorTDDGit.UnitTest
{
    public class CalculatorTest
    {
        [Test]
        public void TestMethod1()
        {
            var fraction1 = 0;
            var fraction2 = 0;
            var calculator = new Calculator();
            var target = calculator.Add(fraction1, fraction2);
            var expected = 0;
            Assert.AreEqual(expected, target);
        }
    }
}
