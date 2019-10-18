using Pocztowy.Models;
using System;

namespace Pocztowy.Calculators.Tests
{
    public class OrderBuilder
    { 
        public static Order BuildWithOneStandardProduct(string date, decimal price)
        {
            Order order = new Order
            {
                NumberOrder = "ZAM 001",
                CreateDate = Convert.ToDateTime(date),
            };

            order.Add(new Product
            {
                Name = "Keyboard",
                Color = "Black",
                UnitPrice = price,
            });
            return order;
        }
    }
}
