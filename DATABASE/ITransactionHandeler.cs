using Dapper;
using MySqlConnector;
using TYPES;
namespace DATABASE;
public interface ITransactionHandeler
{
    public void CreateInternalTransaction(Transactions transaction);

    public void GetTransaction (Transactions transactions);

    
}