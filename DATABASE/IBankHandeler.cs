using Dapper;
using MySqlConnector;
using TYPES;
namespace DATABASE;
public interface IBankHandeler
{
    public List<BankOffice> GetOffices();
}