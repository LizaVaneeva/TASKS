using System;

namespace DeliverySystem
{
    public class Order
    {
        public string ProductName { get; set; }
        public string CourierSurname { get; set; }
        public DateTime DeliveryDateTime { get; set; }

        public readonly string Article;
        public readonly string OrderNumber;
        public readonly OrderType Type;

        public Order(
            string productName,
            string article,
            string courierSurname,
            string orderNumber,
            string deliveryDateTime,
            OrderType type)
        {
            ProductName = productName;
            Article = article;
            CourierSurname = courierSurname;
            OrderNumber = orderNumber;
            Type = type;

            DateTime parsedDateTime;
            if (!DateTime.TryParse(deliveryDateTime, out parsedDateTime))
                throw new ArgumentException("Неверный формат даты и времени");

            DeliveryDateTime = parsedDateTime; 
        }

        public virtual string[] GetInfo()
        {
            string typeStr = Type == OrderType.Express ? "срочный" : "обычный";

            return new string[]
            {
                $"Товар: {ProductName} (Артикул: {Article})",
                $"Заявка #{OrderNumber}. Курьер: {CourierSurname}",
                $"Тип: {typeStr}. Доставка: {DeliveryDateTime:dd.MM.yyyy HH:mm}"
            };
        }
    }
}