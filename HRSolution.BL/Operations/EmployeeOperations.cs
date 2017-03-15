using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSolution.BL.Helper;
using HRSolution.DAL;

namespace HRSolution.BL.Operations
{
    public class EmployeeOperations:IEmployee
    {
        HREntities db = new HREntities();
        /// <summary>
        /// Insert New Recored At Employee Table
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        public int CreateNew(DAL.Employee emp)
        {
            db.Employees.Add(emp);
            int row = db.SaveChanges();
            return row;
        }
        /// <summary>
        /// Edit Existing Employee
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        public int UpdateEmployee(DAL.Employee emp)
        {
            Employee ee = db.Employees.Find(emp.EmployeeId);
            ee.Name = emp.Name;
            ee.Salary = emp.Salary;
            ee.DepartmentId = emp.DepartmentId;
            return db.SaveChanges(); 
        }
        /// <summary>
        /// Delete Employee
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        public int DeleteEmployee(DAL.Employee emp)
        {
            Employee ee = db.Employees.Find(emp.EmployeeId);
            db.Employees.Remove(ee);
            return db.SaveChanges();
        }
        /// <summary>
        /// Retrieve All Employees
        /// </summary>
        /// <returns></returns>
        public List<DAL.Employee> GetAllEmployees()
        {
            return db.Employees.ToList();
        }
        /// <summary>
        /// Search By Employee Name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<DAL.Employee> SearchByName(string name)
        {
            var emps = from emp in db.Employees
                       where emp.Name.Contains(name)
                       select emp;
            return emps.ToList();
        }
        /// <summary>
        /// Search Employee By Employee ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Employee> SearchByID(int id)
        {
            var emps = from emp in db.Employees
                       where emp.EmployeeId == id
                       select emp;
            return emps.ToList();
        }

        public int NextID()
        {
            int nextid = (from emp in db.Employees
                          select emp.EmployeeId).Max();
            return nextid;
        }
    }
}
