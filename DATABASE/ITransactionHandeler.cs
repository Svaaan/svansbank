using Dapper;
using MySqlConnector;
using TYPES;
namespace DATABASE;
public interface ITransactionHandeler
{
    public void CreateInternalTransaction(Transactions transaction);

    public List<Transactions> GetTransactions(int bankId);

    public int CountTransactions ();
}