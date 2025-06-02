using System;

namespace DeliverySystem
{
    public class Order : IComparable<Order>
    {
        public string ProductName { get; set; }
        public string CourierSurname { get; set; }
        public DateTime DeliveryDateTime { get; set; }
        public readonly string Article;
        public readonly string OrderNumber;
        public readonly OrderType Type;

        public Order(string productName, string article, string courierSurname,
                     string orderNumber, string deliveryDateTime, OrderType type)
        {
            ProductName = productName;
            Article = article;
            CourierSurname = courierSurname;
            OrderNumber = orderNumber;
            DeliveryDateTime = DateTime.Parse(deliveryDateTime);
            Type = type;
        }

        public virtual string[] GetInfo()
        {
            return new string[]
            {
                $"Товар: {ProductName} (Артикул: {Article})",
                $"Заявка #{OrderNumber}. Курьер: {CourierSurname}",
                $"Тип: {(Type == OrderType.Express ? "срочный" : "обычный")}. Доставка: {DeliveryDateTime:dd.MM.yyyy HH:mm}"
            };
        }

        public int CompareTo(Order other)
        {
            int surnameComparison = CourierSurname.CompareTo(other.CourierSurname);
            if (surnameComparison != 0) return surnameComparison;

            int typeComparison = other.Type.CompareTo(Type); 
            if (typeComparison != 0) return typeComparison;

            return DeliveryDateTime.CompareTo(other.DeliveryDateTime);
        }
    }
}
