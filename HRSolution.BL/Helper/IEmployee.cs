using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSolution.DAL;

namespace HRSolution.BL.Helper
{
    interface IEmployee
    {
        int CreateNew(Employee emp);
        int UpdateEmployee(Employee emp);
        int DeleteEmployee(Employee emp);
        List<Employee> GetAllEmployees();
        List<Employee> SearchByName(string name);
        List<Employee> SearchByID(int id);
        int NextID();
    }
}
