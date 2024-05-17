using CourierSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierSystem.Repositories
{
    public interface ICourierAdminRepository
    {
        int AddCourierStaff(Employee employee);
    }
}
