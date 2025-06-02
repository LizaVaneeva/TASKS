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

        [Test]
        public void ExpressOrder_GetInfo_ReturnsCorrectStrings()
        {
            var order = new ExpressOrder(
                "Срочный документ",
                "DOC-001",
                "Кузнецов",
                "EXP-2023-001",
                "25.07.2023 09:00",
                1.5,
                DeliveryUrgency.WithinThreeHours);

            var info = order.GetInfo();

            Assert.AreEqual(4, info.Length);
            Assert.AreEqual("Тип: срочный (в течение трех часов), Коэфф: 1,5", info[2]);
        }

        [Test]
        public void InsuredOrder_GetInfo_ReturnsInsuranceInfo()
        {
            var order = new InsuredOrder(
                "Антиквариат",
                "ANT-001",
                "Орлов",
                "INS-2023-001",
                "30.07.2023 15:00",
                OrderType.Regular,
                "Страховая Компания",
                50000m);

            var info = order.GetInfo();

            StringAssert.Contains("Страховка: Страховая Компания (50000 руб.)", info[2]);
        }
    }
}
