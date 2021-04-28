# EmployeeList
Display Employee Information including Search Filter using ASP.NET MVC Core

1. This Project is built using:
      . Visual Studio 2019 as IDE
      . Project Type: ASP.NET MVC Core Web application using C# Language.
      . SQL Server as Backend DB.
      . Front End frameworks: Bootstrap/Javascript/Jquery/HTML/CSS
      . Nuget Packages: X.PagedList.Mvc.Core/Dapper/Microsoft.Data.SqlClient/System.Runtime.Caching
  
2. Pre-requisites:
       .Install the above Nuget Packages in your project
       .Run the db Script files in SQL Server Management Studio to generate the required 3 tables(tables_scripts.txt) and 1 Stored Procedure.(usp_GetEmployeeDetails.txt)
       .make sure you have the sample image files in project wwwroot/images folder.

3. Usage:
      . Open this project in Visual Studio 2019, build it and run.
      . You will be seeing only a single page with Employee Info populated (in a grid).
      . Use search box to filter employees based on Name/Department name/Sub department name.
 
4. Open issues:
      .Paging of the results is not implemented yet.

If you have any suggestions/corrections, you can always email me at: maniraj.bathula@gmail.com.

Project Link: https://github.com/manirajbathula/EmployeeList.git

Thank you
Maniraj
