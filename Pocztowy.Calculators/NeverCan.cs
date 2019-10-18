using Pocztowy.Models;

namespace Pocztowy.Calculators
{
    public class NeverCan : ICanDiscountStrategy
    {
        public static ICanDiscountStrategy Strategy { get; } = new NeverCan();

        public bool CanDiscount(Order order) => false;
    }
}
