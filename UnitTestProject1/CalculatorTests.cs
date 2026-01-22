using System;
using DXApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_TwoNumbers_ReturnsCorrectSum()
        {
            // Arrange (Chuẩn bị)
            var calc = new Calculator();
            int a = 5;
            int b = 3;

            // Act (Hành động)
            int result = calc.Add(a, b);

            // Assert (Kiểm tra)
            Assert.AreEqual(8, result); // Kỳ vọng 5 + 3 = 8
        }
    }
}
