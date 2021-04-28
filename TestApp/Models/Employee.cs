
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public class Employee
    {
		[Key]
        public int EmployeeID { get; set; }
        public int SubDepartmentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }
        public string ProfileImage { get; set; }
        public string FBProfileLink { get; set; }
        public string TwitterProfileLink { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public char Deleted { get; set; }
        public DateTime DeletedDate { get; set; }
      
    }
}
