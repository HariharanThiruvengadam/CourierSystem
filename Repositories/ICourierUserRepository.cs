using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourierSystem.Models;

namespace CourierSystem.Repositories
{
    public interface ICourierUserRepository
    {
        string PlaceOrder(Courier courier);
        string GetOrderStatus(int trackingNumber);
        bool CancelOrder(int trackingNumber);
        List<Courier> GetAssignedOrder(long StaffID);
    }

}
