using Pocztowy.Models;

namespace Pocztowy.Calculators
{
    public class ZeroDiscountStrategy : IDiscountStrategy
    {
        public decimal Discount(Order order) => 0M;
    }
}
