using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.ViewModels;

namespace TestApp.Service
{
    public interface IEmployeeService
    {
        public List<EmployeeVM> GetEmployees(); //(int? page, int pageSize);      
    }
}
