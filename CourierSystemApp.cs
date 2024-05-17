using CourierSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierSystem
{
    internal class CourierSystemApp
    {
        readonly ICourierAdminService _courierAdminService;
        readonly ICourierUserService _courierUserService;

        public CourierSystemApp()
        {
            _courierAdminService = new CourierAdminService();
            _courierUserService = new CourierUserService();
        }

        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("WELCOME TO COURIER SYSTEM APPLICATION \n Here are the options from which you can choose to perform");
                Console.WriteLine("1.User");
                Console.WriteLine("2.Admin");
                Console.WriteLine("3.Exit");
                Console.Write("Select an Option: ");
                
                try
                {
                    int userOption = int.Parse(Console.ReadLine());
                    switch (userOption)
                    {
                        case 1:
                            Console.WriteLine("1.Place order");
                            Console.WriteLine("2.Get order status");
                            Console.WriteLine("3.Cancel order");
                            Console.WriteLine("4.Get assigned order for a particular employee");
                            Console.Write("Select an Option: ");
                            int methodOption = int.Parse(Console.ReadLine());
                            switch (methodOption)
                            {
                                case 1:
                                    _courierUserService.PlaceOrder();
                                    break;
                                case 2:
                                    _courierUserService.GetOrderStatus();
                                    break;
                                case 3:
                                    _courierUserService.CancelOrder();
                                    break;
                                case 4:
                                    _courierUserService.GetAssignedOrder();
                                    break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("1.Add new staff");
                            Console.Write("Select an Option: ");
                            int inputOption = int.Parse(Console.ReadLine());
                            switch (inputOption)
                            {
                                case 1:
                                    _courierAdminService.AddCourierStaff();
                                    break;
                            }
                            break;
                    }

                    if (userOption == 3)
                    {
                        break;
                    }
                }
                catch(FormatException fe)
                {
                    Console.WriteLine(fe.Message);
                }
               
            }
        }
    }
}
