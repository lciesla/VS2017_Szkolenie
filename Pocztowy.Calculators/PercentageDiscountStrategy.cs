using Pocztowy.Models;
using System;

namespace Pocztowy.Calculators
{
    public class PercentageDiscountStrategy : IDiscountStrategy
    {
        private readonly decimal percentage;

        public PercentageDiscountStrategy(decimal percentage)
        {
            this.percentage = percentage;
        }

        public decimal Discount(Order order) => Math.Round(order.Total * percentage,2,MidpointRounding.AwayFromZero);
    }


}
