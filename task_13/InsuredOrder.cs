namespace DeliverySystem
{
    public class InsuredOrder : Order
    {
        public string InsuranceCompany { get; set; }
        public decimal InsuranceAmount { get; set; }

        public InsuredOrder(
            string productName,
            string article,
            string courierSurname,
            string orderNumber,
            string deliveryDateTime,
            OrderType type,
            string insuranceCompany,
            decimal insuranceAmount)
            : base(productName, article, courierSurname, orderNumber, deliveryDateTime, type)
        {
            InsuranceCompany = insuranceCompany;
            InsuranceAmount = insuranceAmount;
        }

        public override string[] GetInfo()
        {
            var baseInfo = base.GetInfo();
            return new string[]
            {
                baseInfo[0],
                baseInfo[1],
                $"{baseInfo[2]}, Страховка: {InsuranceCompany} ({InsuranceAmount} руб.)"
            };
        }
    }
}