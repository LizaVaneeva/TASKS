using NUnit.Framework;
using DeliverySystem;
using System;

namespace DeliverySystem.UnitTests
{
    [TestFixture]
    public class OrderTests
    {
        [Test]
        public void Constructor_ValidData_CorrectInitialization()
        {
            var order = new Order(
                "Ноутбук Lenovo",
                "LT12345",
                "Иванов",
                "ORD-2023-001",
                "15.07.2023 14:30",
                OrderType.Express);

            Assert.AreEqual("Ноутбук Lenovo", order.ProductName);
            Assert.AreEqual("LT12345", order.Article);
            Assert.AreEqual(OrderType.Express, order.Type);
            Assert.AreEqual(new DateTime(2023, 7, 15, 14, 30, 0), order.DeliveryDateTime);
        }

        [Test]
        public void GetInfo_ReturnsCorrectStrings()
        {
            var order = new Order(
                "Смартфон Samsung",
                "SS-G778",
                "Петров",
                "ORD-2023-002",
                "20.07.2023 10:00",
                OrderType.Regular);

            var info = order.GetInfo();

            Assert.AreEqual(3, info.Length);
            Assert.AreEqual("Товар: Смартфон Samsung (Артикул: SS-G778)", info[0]);
            Assert.AreEqual("Заявка #ORD-2023-002. Курьер: Петров", info[1]);
            StringAssert.Contains("Тип: обычный. Доставка: 20.07.2023 10:00", info[2]);
        }
    }
}