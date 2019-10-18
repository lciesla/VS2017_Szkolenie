using System;
using Pocztowy.Models;

namespace Pocztowy.Calculators
{
    public class DayOfWeekDiscountStrategy : ICanDiscountStrategy
    {
        private readonly DayOfWeek dayOfWeek;

        public DayOfWeekDiscountStrategy(DayOfWeek dayOfWeek)
        {
            this.dayOfWeek = dayOfWeek;
        }

        public bool CanDiscount(Order order) => order.CreateDate.DayOfWeek == dayOfWeek;
    }
}
