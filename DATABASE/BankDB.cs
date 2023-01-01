using Dapper;
using MySqlConnector;
using TYPES;
namespace DATABASE;
public class BankDB : IBankHandeler
{
    public List<BankOffice> GetOffices()
    {
        using (MySqlConnection connection = new MySqlConnection($"Server = localhost; Database = svans_bank;Uid=root;Pwd=;"))
        {
            
            string query = "SELECT id AS 'BankId', name AS 'BankName', location AS 'BankLocation', street_adress AS 'BankStreetAdress', street_number AS 'BankStreetNumber', postal_number AS 'BankPostalNumber' FROM bank;";
            List<BankOffice> bankOffices = connection.Query<BankOffice>(query).ToList();
            return bankOffices;
        }
    }
    
}