using Pocztowy.Models;

namespace Pocztowy.Calculators
{
    public class AlwaysCan : ICanDiscountStrategy
    {
        public static ICanDiscountStrategy Strategy { get; } = new AlwaysCan();

        public bool CanDiscount(Order order) => true;
    }
}
