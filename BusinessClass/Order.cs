using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessClass
{
    public class Order
    {
        public int Id { get;}
        public Food Food { get;}
        public decimal Total { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public DateTime PaymentTime { get; set; }
        public Order(int id, Food food, decimal total, DateTime dateTimeCreated, DateTime paymentTime)
        {
            Id = id;
            Food = food;
            Total = total;
            DateTimeCreated = dateTimeCreated;
            PaymentTime = paymentTime;
        }
        public decimal TotalPrice()
        {
            return Total += Food.Price;
        }
    }
    
}
