using Dapper;
using MySqlConnector;
using TYPES;
namespace DATABASE;
public class EmployeeDB : IEmployeeHandeler
{
    //int EmployementNumber, string Name, 
    //string LastName, string Email
    

    public int AddEmployee(Employee employee)
    {
        using (MySqlConnection connection = new MySqlConnection($"Server = localhost; Database = svans_bank;Uid=root;Pwd=;"))
        {
            int rows = 0;
            string query = "INSERT INTO employee_login(employment_number, name, last_name, email) " +
            "VALUES(@EmploymentNumber, @Name, @LastName, @PersonalNumber, @Mail);";

            rows = connection.ExecuteScalar<int>(query, param: employee);
            return rows;
        }
    }
}