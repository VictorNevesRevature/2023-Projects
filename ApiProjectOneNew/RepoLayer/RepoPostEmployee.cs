using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using ModelsLayer;


namespace RepoLayer
{
    public class RepoPostEmployee : IRepoPostEmployee
    {
        /*
        public Ticket ChangeTicketStatus(bool v, TicketStatus newStatus)
        {
            throw new NotImplementedException();
        }

        public List<Ticket>? GetTicketList(bool v)
        {
            throw new NotImplementedException();
        }

        public Ticket NewTicket(object ticketID)
        {
            throw new NotImplementedException();
        }

        public Employee RegisterUser(string email, string emailPassword)
        {
            throw new NotImplementedException();
        }

        public string UserLogin(string email, string emailPassword)
        {
            throw new NotImplementedException();
        }

        public async Task<Employee>? PostEmployeeAsync(Employee emp)
        {
            //use ADO.NET to push to database
            SqlConnection conn = new SqlConnection("");
            SqlCommand command = new SqlCommand($"INSERT INTO Employees (email, emailPasswords) VALUES(@email,@emailPassword", conn);
            conn.Open(); //opening connection

            //parameters to query
            command.Parameters.AddWithValue("@FirstName", emp.fname);
            command.Parameters.AddWithValue("@LastName", emp.lname);
            command.Parameters.AddWithValue("@email", emp.email);
            command.Parameters.AddWithValue("@emailPassword", emp.emailPassword);
            int rowsAffected = await command.ExecuteNonQueryAsync();
            //call the private get a employee to get an employee
            if (rowsAffected == 1)
            {
                conn.Close();
                return emp;
            }
            else
            {
                return null!;
            }
        }*/

        public Employee PostEmployee(Employee emp)
        {
            //string AzureConnectionString = new ConfigurationBuilder().AddJsonFile("appsettings.development.json").Build().GetSection("ConnectionStrings")["MyDatabase"]!;
            SqlConnection conn = new SqlConnection();

            //SqlCommand command = new SqlCommand($"INSERT INTO ERSEmployees (Fname, Lname, Email, Password, IsManager) VALUES(@Fname, @Lname, @Email, @Password,@IsManager)", conn);

            SqlCommand command= new SqlCommand($"insert into ERSEmployees(Fname,Lname,Email, Password, IsManager)"
            + $"SELECT * from (SELECT @Fname as Fname,"
            + $" @Lname as Lname,"
            + $" @Email as Email,"
            + $" @Password as Password,"
            + $" @IsManager as IsManger) as new_value"
            + $" WHERE NOT EXISTS("
            + $" SELECT Email FROM ERSEmployees WHERE"
            + $" Email = @Email)", conn);



            conn.Open(); //opening connection

            //parameters to query
            command.Parameters.AddWithValue("@Fname", emp.fname);
            command.Parameters.AddWithValue("@Lname", emp.lname);
            command.Parameters.AddWithValue("@Email", emp.email);
            command.Parameters.AddWithValue("@Password", emp.password);
            command.Parameters.AddWithValue("@IsManager",emp.isManager);
            int rowsAffected = command.ExecuteNonQuery();
            //call the private get a employee to get an employee
            if (rowsAffected == 1)
            {
                conn.Close();
                return emp;
            }
            else
            {
                Console.WriteLine("This email is already in use.");
                return null!;
            }
        }
    }
}