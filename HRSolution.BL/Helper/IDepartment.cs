using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRSolution.DAL;

namespace HRSolution.BL.Helper
{
    interface IDepartment
    {
        
        List<Department> GetAllDepartment();
        
    }
}
