using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierSystem.Models
{
    public class Courier
    {
          public long? CourierID { get; set; }
          public string SenderName { get; set; }
          public string SenderAddress { get; set; }
          public string ReceiverName { get; set; }
          public  string ReceiverAddress { get; set; }
          public decimal Weight { get; set; }
          public string Status { get; set; }

        public int TrackingNumber { get; set; }

        public static int nextTrackingNumber =1004;
          public DateTime DeliveryDate { get; set; }
         public long UserId { get; set; }
        public long EmployeeId { get; set; }
        public long ServiceId {  get; set; }

        public Courier()
        {

        }
        public Courier(long? courierId, string senderName, string senderAddress, string receiverName, string receiverAddress, decimal weight, string status, DateTime deliveryTime, long userId, long employeeId, long serviceId)
        {
            CourierID = courierId;
            SenderName = senderName;
            SenderAddress = senderAddress;
            ReceiverName = receiverName;
            ReceiverAddress = receiverAddress;
            Weight = weight;
            Status = status;
            DeliveryDate = deliveryTime;
            UserId = userId;
            EmployeeId = employeeId;
            ServiceId = serviceId;
            TrackingNumber = nextTrackingNumber++;

        }

        


    }
}
