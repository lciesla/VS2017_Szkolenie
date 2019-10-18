using Pocztowy.Models;

namespace Pocztowy.Calculators
{
    public class NoDiscountStrategy : IDiscountStrategy
    {
        public bool CanDiscount(Order order) => false;

        public decimal Discount(Order order) => 0M;
    }
}
