using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DeliverySystem
{
    public class Delivery : IEnumerable<Order>
    {
        public string CourierSurname { get; }
        public DateTime DeliveryDate { get; }
        public int Count => orders.Count;

        private readonly List<Order> orders = new List<Order>();

        public Delivery(string courierSurname, string deliveryDate, IEnumerable<Order> ordersCollection)
        {
            CourierSurname = courierSurname;

            if (!DateTime.TryParse(deliveryDate, out DateTime date))
                throw new ArgumentException("Неверный формат даты доставки");
            DeliveryDate = date.Date;

            foreach (var order in ordersCollection)
            {
                if (order.CourierSurname == courierSurname &&
                    order.DeliveryDateTime.Date == DeliveryDate &&
                    !orders.Any(o => o.OrderNumber == order.OrderNumber))
                {
                    orders.Add(order);
                }
            }
        }

        public IEnumerator<Order> GetEnumerator() => orders.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}