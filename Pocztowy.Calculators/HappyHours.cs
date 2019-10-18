using System;
using Pocztowy.Models;

namespace Pocztowy.Calculators
{
    public class HappyHours : ICanDiscountStrategy
    {
        private readonly TimeSpan from;
        private readonly TimeSpan to;
        private ICanDiscountStrategy strategy;

        public HappyHours(TimeSpan from, TimeSpan to, ICanDiscountStrategy strategy = null)
        {
            this.from = from;
            this.to = to;
            this.strategy = strategy ?? AlwaysCan.Strategy;
        }

        public bool CanDiscount(Order order) =>
            strategy.CanDiscount(order)
            && from <= order.CreateDate.TimeOfDay
            && to >= order.CreateDate.TimeOfDay;
    }
}
