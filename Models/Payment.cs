using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierSystem.Models
{
    public class Payment
    {
       public long PaymentID { get; set; }
       public long CourierID { get; set; }
       public decimal Amount { get; set; }
       public DateTime PaymentDate { get; set; }


        public Payment() { }
        public Payment(long paymentID, long courierID, decimal amount, DateTime paymentDate)
        {
            PaymentID = paymentID;
            CourierID = courierID;
            Amount = amount;
            PaymentDate = paymentDate;
        }
    }
}
