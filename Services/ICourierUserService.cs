using CourierSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierSystem.Services
{
    internal interface ICourierUserService
    {
        void PlaceOrder();
        void GetOrderStatus();
        void CancelOrder();
        void GetAssignedOrder();
    }
}
