using Dapper;
using MySqlConnector;
namespace DATABASE;
class BankDB
{
    public List <BankDB> BankOffices = new();

     public int AddOffice()
    {
        using (MySqlConnection connection = new MySqlConnection($"Server = localhost; Database = svans_bank;Uid=rood;Pwd=;"))
        {
            int rows = 0;
            string query = "INSERT INTO customer(name,location, street_adress, street_number, postal_number)VALUES(@Name,@Location, @StreetAdress, @StreetNumber, @PostalNumber);";
            rows = connection.ExecuteScalar<int>(query, param: BankOffices);
            return rows;
        }
    }
    
}