using Pocztowy.Models;
using Xunit;
using FluentAssertions;
using System;

namespace Pocztowy.Calculators.Tests
{
    public class DayOfWeekDiscountStrategyTest
    {
        [Theory(DisplayName = "Strategia zależna od dnia tygodnia ")]
        [InlineData("2019-10-17", false)]
        [InlineData("2019-10-18", true)]
        public void DayOfWeekDiscountStrategyCanTest(string date, bool expected)
        {
            Order order = OrderBuilder.BuildWithOneStandardProduct(date, 100);
            var strategy = new DayOfWeekDiscountStrategy(DayOfWeek.Friday);
            var result = strategy.CanDiscount(order);
            result.Should().Be(expected);
        }
    }

    public class HappyHoursTests
    {
        [Theory(DisplayName = "Strategia zależna od godzin")]
        [InlineData("2019-01-01 10:30", "2019-01-01 12:30", "2019-01-01 10:30", true)]
        public void HappyHoursTest(string from, string to, string orderTime, bool expected)
        {
            Order order = OrderBuilder.BuildWithOneStandardProduct(orderTime, 100);
            var strategy = new HappyHours(DateTime.Parse(from).TimeOfDay, DateTime.Parse(to).TimeOfDay);
            var result = strategy.CanDiscount(order);
            result.Should().Be(expected);
        }


    }
}