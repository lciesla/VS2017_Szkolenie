using Pocztowy.Models;
using Xunit;
using FluentAssertions;
using System;

namespace Pocztowy.Calculators.Tests
{
    public class OrderCalculatorTests
    {

        [Theory(DisplayName = "Kalkulator ze strategią bez rabatu")]
        [InlineData("2019-10-17", 1000)]
        [InlineData("2019-10-18", 1234)]
        public void DiscountCalculatorNoDiscountStrategyTest(string date, decimal price)
        {
            Order order = OrderBuilder.BuildWithOneStandardProduct(date, price);
            var calculator = new DiscountCalculator(new AlwaysCan(), new ZeroDiscountStrategy());
            var result = calculator.CalculateDiscount(order);
            result.Should().Be(0);
        }

        [Theory(DisplayName = "Kalkulator ze strategią wszystko gratis")]
        [InlineData("2019-10-17", 1000)]
        [InlineData("2019-10-18", 1234)]
        public void DiscountCalculatorFullDiscountStrategyTest(string date, decimal price)
        {
            Order order = OrderBuilder.BuildWithOneStandardProduct(date, price);
            var calculator = new DiscountCalculator(new AlwaysCan(), new FullDiscountStrategy());
            var result = calculator.CalculateDiscount(order);
            result.Should().Be(price);
        }

        [Fact(DisplayName = "Sprawdzenie sieźki false kalkulatora")]
        public void DiscountCalculatorFakeTest()
        {
            Order order = OrderBuilder.BuildWithOneStandardProduct("2019-10-17", 123M);
            var calculator = new DiscountCalculator(new NeverCan(), new FakeStrategy());
            var result = calculator.CalculateDiscount(order);
            result.Should().Be(0);
        }

        private class FakeStrategy : IDiscountStrategy
        {
            public decimal Discount(Order order) => throw new InvalidOperationException();
        }
    }
}
