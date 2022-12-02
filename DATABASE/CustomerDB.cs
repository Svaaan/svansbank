using DATABASE;
using Dapper;
using MySqlConnector;
namespace DATABASE;
class Customer
{
    public int AddCustomer()
    {
        List <Customer> customer = new();

        using (MySqlConnection connection = new MySqlConnection ($"Server = localhost; Database = svans_bank;Uid=rood;Pwd=;"))
        {
            int rows = 0;
            string query = "INSERT INTO customer(name, last_name, personal_number ,mail, phone_number, location, street_adress, street_number, postal_number )VALUES(@name,@SocialSecurityNumber,@email,@passWord);";
            rows = connection.ExecuteScalar<int>(query, param: customer);
            return rows;
        }

    }

}
