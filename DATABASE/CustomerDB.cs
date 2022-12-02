using DATABASE;
using Dapper;
using MySqlConnector;
namespace DATABASE;
class Customer
{
    public List <Customer> customer = new();
    public int AddCustomer()
    {

        using (MySqlConnection connection = new MySqlConnection ($"Server = localhost; Database = svans_bank;Uid=rood;Pwd=;"))
        {
            int rows = 0;
            string query = "INSERT INTO customer(name, last_name, personal_number ,mail, phone_number, location, street_adress, street_number, postal_number, pass_word )VALUES(@name, @lastName, @personalNumber, @mail, @phoneNumber, @location, @streetAdress, @streetNumber, @postalNumber, @passWord);";
            rows = connection.ExecuteScalar<int>(query, param: customer);
            return rows;
        }

    }

}
