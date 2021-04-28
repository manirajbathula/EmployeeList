using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Data;
using TestApp.ViewModels;

namespace TestApp.Service
{
    public class EmployeeService : IEmployeeService
    {       
        public List<EmployeeVM> GetEmployees() //(int? pageNumber, int pageSize)
        {
           using (SqlConnection con = new SqlConnection(DbConnectionManager.Value))
            {
                var param = new DynamicParameters();
                //param.Add("@pageNumber", pageNumber);
                //param.Add("@pageSize", pageSize);                
                var data = con.Query<EmployeeVM>("usp_GetEmployeeDetails", param, commandType: System.Data.CommandType.StoredProcedure).ToList();
                return data;

            }
        }
    }
}
