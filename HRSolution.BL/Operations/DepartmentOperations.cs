using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSolution.BL.Helper;
using HRSolution.DAL;

namespace HRSolution.BL.Operations
{
    public class DepartmentOperations:IDepartment
    {
        HREntities db = new HREntities();
        /// <summary>
        /// Select All Departments
        /// </summary>
        /// <returns></returns>
        public List<DAL.Department> GetAllDepartment()
        {
            return db.Departments.ToList();
        }
    }
}
