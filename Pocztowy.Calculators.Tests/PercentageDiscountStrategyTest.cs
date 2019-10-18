using Xunit;
using FluentAssertions;

namespace Pocztowy.Calculators.Tests
{
    public class PercentageDiscountStrategyTest
    {
        [Theory(DisplayName = "Strategia naliczania rabatu procentowego")]
        [InlineData(0.5, 100, 50)]
        [InlineData(0.5, 99.99, 50.00)]
        [InlineData(0.5, 99.98, 49.99)]
        [InlineData(0.5, 0, 0)]
        [InlineData(0.5, 0.01, 0.01)]
        public void PercentageDiscountStrategypuTest(decimal percentage, decimal unitPrice, decimal expected)
        {
            var givenOrder = OrderBuilder.BuildWithOneStandardProduct("2019-01-01", unitPrice);
            var strategy = new PercentageDiscountStrategy(percentage);
            var result = strategy.Discount(givenOrder);
            result.Should().Be(expected);
        }

    }
}