using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.ViewModels;
using X.PagedList;

namespace TestApp.Utilities
{
    public class EmployeesPaging
    {
        public int? pageSize;
        public string searchStr;
        public int? recCount;
        public StaticPagedList<EmployeeVM> FilteredEmployees { get; set; }
    }
}
