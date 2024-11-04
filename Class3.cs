using System.Collections.Generic;

namespace formquanlykhachhang
{
    public class Invoice
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public List<Service> Services { get; set; } = new List<Service>();
        public int TotalProducts => Services.Count;
        public decimal TotalPrice => CalculateTotalPrice();

        private decimal CalculateTotalPrice()
        {
            decimal total = 0;
            foreach (var service in Services)
            {
                total += service.Price;
            }
            return total;
        }
    }
}
