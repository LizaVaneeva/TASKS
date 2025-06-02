using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace DeliverySystem.UnitTests
{
    [TestFixture]
    public class OrderComparisonTests
    {
        [Test]
        public void CompareTo_OrdersSortedCorrectly()
        {
            var order1 = new Order("Ноутбук", "LT123", "Иванов", "ORD1", "2023-07-15 14:00", OrderType.Regular);
            var order2 = new Order("Телефон", "PH456", "Иванов", "ORD2", "2023-07-15 10:00", OrderType.Express);
            var order3 = new Order("Планшет", "TB789", "Петров", "ORD3", "2023-07-16 09:00", OrderType.Express);

            var orders = new List<Order> { order1, order2, order3 };
            orders.Sort();

            Assert.That(orders, Is.EqualTo(new[] { order2, order1, order3 }));
        }
    }

    [TestFixture]
    public class DeliveryTests
    {
        [Test]
        public void Constructor_FiltersOrdersCorrectly()
        {
            var orders = new List<Order>
            {
                new Order("Товар1", "A1", "Иванов", "O1", "2023-07-15 10:00", OrderType.Express),
                new Order("Товар2", "A2", "Иванов", "O2", "2023-07-15 14:00", OrderType.Regular),
                new Order("Товар3", "A3", "Петров", "O3", "2023-07-15 11:00", OrderType.Express),
                new Order("Товар4", "A4", "Иванов", "O4", "2023-07-16 09:00", OrderType.Express)
            };

            var delivery = new Delivery("Иванов", "2023-07-15", orders);

            Assert.That(delivery.Count, Is.EqualTo(2));
            Assert.That(delivery, Has.Some.Matches<Order>(o => o.OrderNumber == "O1"));
            Assert.That(delivery, Has.Some.Matches<Order>(o => o.OrderNumber == "O2"));
        }

        [Test]
        public void Enumerable_ReturnsCorrectOrders()
        {
            var order1 = new Order("Товар1", "A1", "Иванов", "O1", "2023-07-15 10:00", OrderType.Express);
            var order2 = new Order("Товар2", "A2", "Иванов", "O2", "2023-07-15 14:00", OrderType.Regular);
            var delivery = new Delivery("Иванов", "2023-07-15", new[] { order1, order2 });

            int count = 0;
            foreach (var order in delivery)
            {
                count++;
                Assert.That(order.CourierSurname, Is.EqualTo("Иванов"));
                Assert.That(order.DeliveryDateTime.Date, Is.EqualTo(new DateTime(2023, 7, 15)));
            }

            Assert.That(count, Is.EqualTo(2));
        }
    }
}
