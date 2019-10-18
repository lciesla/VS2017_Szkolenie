using Pocztowy.Models;

namespace Pocztowy.Calculators
{
    public interface IOrderDiscountCalculator
    {
        decimal CalculateDiscount(Order order);
    }
}