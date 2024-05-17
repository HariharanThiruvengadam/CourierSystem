using CourierManagement.Utility;
using CourierSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CourierSystem.Repositories;

namespace CourierSystem.Services
{
    internal class CourierAdminService:ICourierAdminService
    {
        readonly ICourierAdminRepository courierAdminRepo;

        public CourierAdminService() { 
            courierAdminRepo = new CourierAdminRepository();   
        }
        public void AddCourierStaff()
        {

           
            Console.Write("Enter the employee name: ");
            string employeeName = Console.ReadLine();
            Console.Write("Enter the email address: ");
            string email = Console.ReadLine();
            Console.Write("Enter the contact number: ");
            string contactNumber = Console.ReadLine();
            Console.Write("Enter the role: ");
            string role = Console.ReadLine();
            Console.Write("Enter the salary: ");
            decimal salary = decimal.Parse(Console.ReadLine());
           

            Employee emp = new Employee(null, employeeName,email,contactNumber,role,salary);
            int empId = courierAdminRepo.AddCourierStaff(emp);

            if (empId > 0)
            {
                Console.WriteLine(empId);
            }
            else
            {
                Console.WriteLine("Failed to add staff details");
            }
        }

    }
}
