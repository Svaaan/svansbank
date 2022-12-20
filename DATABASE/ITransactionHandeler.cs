using Dapper;
using MySqlConnector;
using TYPES;
namespace DATABASE;
public interface ITransactionHandeler
{
    public void CreateWithdrawalTransaction(Transactions transaction);

    public void GetTransaction (Transactions transactions);

    
}