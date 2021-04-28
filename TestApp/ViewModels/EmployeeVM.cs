using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.ViewModels
{
    public class EmployeeVM
    {
        public int EmployeeId { get; set; }
        public string EmployeeFullName { get; set; }
        public string EmployeeBio { get; set; }
        public string EmployeeProfileImage { get; set; }
        public string EmployeeFBProfileLink { get; set; }
        public string EmployeeTwitterProfileLink { get; set; }
        public string EmployeeDepartmentName { get; set; }
        public string EmployeeSubDepartmentName { get; set; }
    }
}
