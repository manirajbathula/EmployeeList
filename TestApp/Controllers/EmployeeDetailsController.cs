using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TestApp.Service;
using TestApp.Utilities;
using TestApp.ViewModels;
using X.PagedList;
using System.Runtime.Caching;

namespace TestApp.Controllers
{
    public class EmployeeDetailsController : Controller
    {
        IEmployeeService _IEmployeeService;
        public EmployeeDetailsController(IEmployeeService IEmpService)
        {
            _IEmployeeService = IEmpService;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public IActionResult GetEmployees(int? page=1, string searchStr ="")
        {
            EmployeesPaging empPaging = new EmployeesPaging();
            var empCount = 0;
            List<EmployeeVM> allEmployees = new List<EmployeeVM>();
            List<EmployeeVM> filteredEmployees = new List<EmployeeVM>();
            if (page <0)
            {
                page = 1;
            }
            var pageIndex = (page ?? 1) - 1;
            var pageSize = 10;
            string newSearchStr = string.Empty;
            if(!string.IsNullOrEmpty(searchStr))
            {
                newSearchStr = Regex.Replace(searchStr, @"[^a-zA-Z0-9\s]", string.Empty);
            }
            if (MemoryCache.Default["allEmpList"] == null)
            {
                allEmployees = _IEmployeeService.GetEmployees().ToList();// (page, pageSize).ToList();
                MemoryCache.Default["allEmpList"] = allEmployees;
                filteredEmployees = allEmployees;
            }
            else
            {
                allEmployees = (List<EmployeeVM>)MemoryCache.Default["allEmpList"];
                filteredEmployees = allEmployees.Where(emp => emp.EmployeeFullName.ToLower().Contains(newSearchStr.ToLower()) ||
                                                       emp.EmployeeDepartmentName.ToLower().Contains(newSearchStr.ToLower()) ||
                                                       emp.EmployeeSubDepartmentName.ToLower().Contains(newSearchStr.ToLower())).ToList();
            }
            empCount= filteredEmployees.Count;

            var employeesPerPage = new StaticPagedList<EmployeeVM>(filteredEmployees, pageIndex + 1, pageSize, empCount);
            empPaging.FilteredEmployees = employeesPerPage;
            empPaging.pageSize = pageSize;
            empPaging.recCount = empCount;

            return View(empPaging);
        }
    }
}
