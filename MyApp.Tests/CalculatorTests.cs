using MyApp.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_TwoNumbers_ReturnsSum()
        {
            var calc = new Calculators();

            var result = calc.Add(2, 3);

            Assert.Equal(5, result);
        }

        [Fact]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            var calc = new Calculators();

            var result = calc.Subtract(5, 3);

            Assert.Equal(2, result);
        }
    }
}
