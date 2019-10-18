using Pocztowy.Models;

namespace Pocztowy.Calculators
{

    public class AlwaysCan : ICanDiscountStrategy
    {
        public static ICanDiscountStrategy Strategy { get; } = new AlwaysCan();

        public bool CanDiscount(Order order) => true;
    }

    public class NeverCan : ICanDiscountStrategy
    {
        public static ICanDiscountStrategy Strategy { get; } = new NeverCan();

        public bool CanDiscount(Order order) => false;
    }

    public class ZeroDiscountStrategy : IDiscountStrategy
    {
        public decimal Discount(Order order) => 0M;
    }
    public class FullDiscountStrategy : IDiscountStrategy
    {
        public decimal Discount(Order order) => order.Total;
    }
}
