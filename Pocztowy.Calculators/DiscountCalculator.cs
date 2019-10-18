using System;
using Pocztowy.Models;

namespace Pocztowy.Calculators
{
    public class DiscountCalculator : IDiscountCalculator
    {
        private ICanDiscountStrategy canDiscountStrategy;
        private IDiscountStrategy discountStrategy;

        public DiscountCalculator(ICanDiscountStrategy canDiscountStrategy, IDiscountStrategy discountStrategy)
        {
            this.canDiscountStrategy = canDiscountStrategy ?? throw new ArgumentNullException(nameof(canDiscountStrategy));
            this.discountStrategy = discountStrategy ?? throw new ArgumentNullException(nameof(discountStrategy));
        }

        public decimal CalculateDiscount(Order order)
        {
            if (canDiscountStrategy.CanDiscount(order))
            {
                return discountStrategy.Discount(order);
            }
            else
            {
                return 0M;
            }
        }
    }
}
