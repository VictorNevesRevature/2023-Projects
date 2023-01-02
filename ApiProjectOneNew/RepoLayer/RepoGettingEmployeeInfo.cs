using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using ModelsLayer;

namespace RepoLayer
{
    public class RepoGettingEmployeeInfo : IRepoGettingEmployeeInfo
    {
        public List<Employee> GettingEmployeeInfo()
        {
            //SQL
            List<Employee> EmployeeInfoList= new List<Employee>();

            //string AzureConnectionString = new ConfigurationBuilder().AddJsonFile("appsettings.development.json").Build().GetSection("ConnectionStrings")["MyDatabase"]!;
            SqlConnection conn = new SqlConnection();

            //SqlCommand command = new SqlCommand($"INSERT INTO ERSEmployees (Fname, Lname, Email, Password, IsManager) VALUES(@Fname, @Lname, @Email, @Password,@IsManager)", conn);

            SqlCommand command= new SqlCommand($"SELECT * FROM ERSEmployees", conn);



            conn.Open(); //opening connection

            //parameters to query
            
           

            SqlDataReader resultSet = command.ExecuteReader(); // return record/s in a different format

            while(resultSet.Read()) // this method goes through each row of the result set
            {
                Employee employee= new Employee(resultSet.GetInt32(0), resultSet.GetString(1),resultSet.GetString(2),resultSet.GetString(3), resultSet.GetString(4), resultSet.GetBoolean(5));
                EmployeeInfoList.Add(employee);
                
                
            }
            Console.WriteLine($"Employees List: {EmployeeInfoList.Count}");

            
            conn.Close();
            return EmployeeInfoList;
        }


        
    }
}