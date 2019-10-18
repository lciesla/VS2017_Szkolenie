using Pocztowy.Models;

namespace Pocztowy.Calculators
{

    public interface IDiscountCalculator
    {
        decimal CalculateDiscount(Order order);
    }

    public interface IDiscountStrategy
    {
        decimal Discount(Order order);
    }

    public interface ICanDiscountStrategy
    {
        bool CanDiscount(Order order);
    }
}
