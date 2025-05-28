namespace DeliverySystem
{
    public class ExpressOrder : Order
    {
        public double SurchargeCoefficient { get; set; }
        public DeliveryUrgency Urgency { get; set; }

        public ExpressOrder(
            string productName,
            string article,
            string courierSurname,
            string orderNumber,
            string deliveryDateTime,
            double surchargeCoefficient,
            DeliveryUrgency urgency)
            : base(productName, article, courierSurname, orderNumber, deliveryDateTime, OrderType.Express)
        {
            SurchargeCoefficient = surchargeCoefficient;
            Urgency = urgency;
        }

public override string[] GetInfo()
{
    string urgencyStr;
    switch (Urgency)
    {
        case DeliveryUrgency.WithinHour:
            urgencyStr = "в течение часа";
            break;
        case DeliveryUrgency.WithinThreeHours:
            urgencyStr = "в течение трех часов";
            break;
        case DeliveryUrgency.WithinDay:
            urgencyStr = "в течение суток";
            break;
        default:
            urgencyStr = "не определена";
            break;
    }

    return new string[]
    {
        $"Товар: {ProductName} (Артикул: {Article})",
        $"Заявка #{OrderNumber}. Курьер: {CourierSurname}",
        $"Тип: срочный ({urgencyStr}), Коэфф: {SurchargeCoefficient}",
        $"Доставка: {DeliveryDateTime:dd.MM.yyyy HH:mm}"
    };
}
    }
}