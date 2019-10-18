using Pocztowy.Models;

namespace Pocztowy.Calculators
{
    public class MinTotal : ICanDiscountStrategy
    {
        private readonly decimal minTotal;
        private readonly ICanDiscountStrategy strategy;

        public MinTotal(decimal minTotal, ICanDiscountStrategy strategy = null)
        {
            this.minTotal = minTotal;
            this.strategy = strategy ?? AlwaysCan.Strategy;
        }

        public bool CanDiscount(Order order) => strategy.CanDiscount(order) && order.Total >= minTotal;
    }
}
