using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierSystem.Models
{
    public class User
    {
       public long UserID { get; set; }
       public  string UserName { get; set; }
       public  string Email { get; set; }
       public  string Password { get; set; }
       public  string ContactNumber { get; set; }
       public  string Address { get; set; }

        public User()
        {

        }
        public User(int userId, string userName, string email, string password, string contactNumber, string address)
        {
            UserID = userId;
            UserName = userName;
            Email = email;
            Password = password;
            ContactNumber = contactNumber;
            Address = address;
        }
    }
}
