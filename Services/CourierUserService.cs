using CourierManagement.Utility;
using CourierSystem.Exception;
using CourierSystem.Models;
using CourierSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CourierSystem.Services
{
    internal class CourierUserService:ICourierUserService
    {
        readonly ICourierUserRepository courierUserRepo;

        public CourierUserService()
        {
            courierUserRepo = new CourierUserRepository();
        }

        public void PlaceOrder()
        {
           /* Console.Write("Enter the courier id: ");
            long? courierId = long.Parse(Console.ReadLine());*/
            Console.Write("Enter the sender name: ");
            string senderName = Console.ReadLine();
            Console.Write("Enter the  sender address: ");
            string senderAddress = Console.ReadLine();
            Console.Write("Enter the receiver name: ");
            string receiverName = Console.ReadLine();
            Console.Write("Enter the receiver address: ");
            string receiverAddress = Console.ReadLine();
            Console.Write("Enter the weight: ");
            decimal weight = decimal.Parse(Console.ReadLine());
            Console.Write("Enter the status: ");
            string status = Console.ReadLine();
            Console.Write("Enter the delivery date: ");
            DateTime deliveryDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Enter the user id: ");
            long userId = long.Parse(Console.ReadLine());
            Console.Write("Enter the employee id: ");
            long employeeId = long.Parse(Console.ReadLine());
            Console.Write("Enter the service id: ");
            long serviceId = long.Parse(Console.ReadLine());

            Courier newOrder = new Courier(null,senderName, senderAddress, receiverName,receiverAddress,weight,status,deliveryDate,userId,employeeId,serviceId);

            string trackingNumber = courierUserRepo.PlaceOrder(newOrder);

            if (trackingNumber.Length > 0)
            {
                Console.WriteLine($"Placed the order Successfully, Your tracking number is{trackingNumber}");
            }
            else
            {
                Console.WriteLine("Failed to place the order");
            }
        }
        public void GetOrderStatus()
        {
            Console.Write("Enter the tracking number:");
            int trackingNumber = int.Parse(Console.ReadLine());
            try
            {
                string orderStatus = courierUserRepo.GetOrderStatus(trackingNumber);
                if (orderStatus.Length >0)
                {
                    Console.WriteLine($"Your order status:{orderStatus}");
                }
                else
                {
                    throw new TrackingNumberNotFoundException("Tracking number is not found...");
                }
            }catch(TrackingNumberNotFoundException tnex)
            {
                Console.WriteLine(tnex.Message);
            }
           
        }
        public void CancelOrder()
        {
            Console.Write("Enter the tracking number:");
            int trackingNumber = int.Parse(Console.ReadLine());

            try
            {
                bool status = courierUserRepo.CancelOrder(trackingNumber);

                if (status)
                {
                    Console.WriteLine($"Cancelled succesfully!!");
                }
                else
                {
                    throw new TrackingNumberNotFoundException("Tracking number is not found...");
                }
            }catch (TrackingNumberNotFoundException tnex)
            {
                Console.WriteLine(tnex.Message);
            }

        }
        public void GetAssignedOrder()
        {
            Console.Write("Enter the staff id:");
            int staffId = int.Parse(Console.ReadLine());
            List<Courier> couriers = courierUserRepo.GetAssignedOrder(staffId);

            if (couriers.Count > 0)
            {
                foreach (Courier c in couriers)
                {
                    Console.WriteLine("Courier ID: "+c.CourierID + " is assigned to" + c.EmployeeId + "" + c.DeliveryDate);
                }
            }
            else
            {
                Console.WriteLine("There is no order assigned to this staff");
            }
        }
    }
}
