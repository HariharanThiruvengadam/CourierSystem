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
    public class CourierUserRepository:ICourierUserRepository
    {
        SqlConnection sqlConnection = null;
        SqlCommand cmd = null;


        public CourierUserRepository()
        {
            sqlConnection = new SqlConnection(ConnectionUtil.GetConnectionString());
            cmd = new SqlCommand();
        }
        public string PlaceOrder(Courier courier)
        {
            cmd.Parameters.Clear();
            sqlConnection.Open();
            cmd.Connection = sqlConnection;
            cmd.CommandText = "Insert into Courier OUTPUT INSERTED.TrackingNumber values(@SenderName,@SenderAddress,@ReceiverName,@ReceiverAddress,@Weight,@Status,@trackingNumber,@DeliveryDate,@employeeId,@userId,@serviceId)";
            /*cmd.Parameters.AddWithValue("@CourierID", courier.CourierID);*/
            cmd.Parameters.AddWithValue("@SenderName", courier.SenderName);
            cmd.Parameters.AddWithValue("@SenderAddress", courier.SenderAddress);
            cmd.Parameters.AddWithValue("@ReceiverName", courier.ReceiverName);
            cmd.Parameters.AddWithValue("@ReceiverAddress", courier.ReceiverAddress);
            cmd.Parameters.AddWithValue("@Weight", courier.Weight);
            cmd.Parameters.AddWithValue("@Status", courier.Status);
            cmd.Parameters.AddWithValue("@trackingNumber", Convert.ToString(courier.TrackingNumber));
            cmd.Parameters.AddWithValue("@DeliveryDate", courier.DeliveryDate);
            cmd.Parameters.AddWithValue("@employeeId", courier.EmployeeId);
            cmd.Parameters.AddWithValue("@userId", courier.UserId);
            cmd.Parameters.AddWithValue("@serviceId", courier.ServiceId);
            string TrackingNumber = Convert.ToString(cmd.ExecuteScalar());
            sqlConnection.Close();
            return TrackingNumber;
        }

        public string GetOrderStatus(int trackingNumber)
        {

            cmd.Parameters.Clear();
            string status = "";

            sqlConnection.Open();
            cmd.Connection = sqlConnection;
            cmd.CommandText = "SELECT Status FROM Courier WHERE TrackingNumber = @trackingNumber";
            cmd.Parameters.AddWithValue("@trackingNumber", trackingNumber);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                status = reader["Status"].ToString();
            }

            reader.Close();
            sqlConnection.Close();
            return status;
        }

        public bool CancelOrder(int trackingNumber)
        {
            cmd.Parameters.Clear();
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            cmd.CommandText = "delete from courier where trackingNumber=@trackingNumber";
            cmd.Parameters.AddWithValue("@trackingNumber",trackingNumber);
            int status = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return status > 0 ? true : false;
        }

        public List<Courier> GetAssignedOrder(long StaffID)
        {
            cmd.Parameters.Clear();
            sqlConnection.Open();
            cmd.Connection = sqlConnection;

            cmd.CommandText = "SELECT * FROM Courier WHERE employeeId  = @employeeID";
            cmd.Parameters.AddWithValue("@employeeID", StaffID);
           
            SqlDataReader reader = cmd.ExecuteReader();

            List<Courier> couriers = new List<Courier>();


            while (reader.Read())
            {

                Courier courier = new Courier();
                courier.CourierID = (int)reader["CourierId"];
                courier.EmployeeId = (int)reader["EmployeeId"];
                courier.DeliveryDate = Convert.ToDateTime(reader["DeliveryDate"]);
                /* Console.WriteLine(courier.CourierID + " " + courier.EmployeeId + " " + courier.DeliveryDate);*/
                couriers.Add(courier);
            }

            reader.Close();
            sqlConnection.Close();
            return couriers;
        }

    }
}
