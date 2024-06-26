﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierSystem.Models
{
    public class Employee
    {
       public  long? EmployeeID { get; set; }
       public  string EmployeeName { get; set; }
       public  string Email { get; set; }
       public  string ContactNumber { get; set; }
       public  string Role { get; set; }
       public decimal Salary { get; set; }

        public Employee() { }
        public Employee(long? employeeID, string employeeName, string email, string contactNumber, string role, decimal salary)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName;
            Email = email;
            ContactNumber = contactNumber;
            Role = role;
            Salary = salary;
        }
    }
}
