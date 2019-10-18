using Pocztowy.Models;

namespace Pocztowy.Calculators
{
    public interface IDiscountStrategy
    {
        decimal Discount(Order order);
    }
}
