using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public class SubDepartment
    {
		[Key]
		public int SubDepartmentID { get; set; }
		public int DepartmentID { get; set; }		
		public string SubDepartmentName { get; set; }
		public DateTime AddedDate { get; set; }
		public DateTime UpdatedDate { get; set; }
		public char Deleted { get; set; }
		public DateTime DeletedDate { get; set; }
	
    }
}
