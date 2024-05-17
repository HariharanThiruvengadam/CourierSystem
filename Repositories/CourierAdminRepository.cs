using CourierManagement.Utility;
using CourierSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierSystem.Repositories
{
    public class CourierAdminRepository:ICourierAdminRepository
    {
        SqlConnection sqlConnection = null;
        SqlCommand cmd = null;


        public CourierAdminRepository()
        {
            sqlConnection = new SqlConnection(ConnectionUtil.GetConnectionString());
            cmd = new SqlCommand();
        }

        public int AddCourierStaff(Employee employee)
        {
            cmd.Parameters.Clear();
            int newStaffId =0;
            cmd.Connection = sqlConnection;
            sqlConnection.Open();

            cmd.CommandText = "INSERT INTO Employee OUTPUT INSERTED.EmployeeID VALUES (@Name,@Email,@ContactNumber,@Role,@Salary)";

            cmd.Parameters.AddWithValue("@Name", employee.EmployeeName);
            cmd.Parameters.AddWithValue("@ContactNumber", employee.ContactNumber);
            cmd.Parameters.AddWithValue("@Email", employee.Email);
            cmd.Parameters.AddWithValue("@Salary", employee.Salary);
            cmd.Parameters.AddWithValue("@Role", employee.Role); ;

            newStaffId = (int)cmd.ExecuteScalar();

            sqlConnection.Close();
            return newStaffId;
        }
    }
}
