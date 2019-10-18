using Pocztowy.Models;

namespace Pocztowy.Calculators
{
    public class FullDiscountStrategy : IDiscountStrategy
    {
        public decimal Discount(Order order) => order.Total;
    }
}
