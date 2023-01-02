using Dapper;
using MySqlConnector;
using Dapper;
using MySqlConnector;
using TYPES;
namespace DATABASE;

public class TransactionDB : ITransactionHandeler
{
    public void CreateInternalTransaction(Transactions transaction)
    {
        using MySqlConnection connection = new MySqlConnection($"Server = localhost; Database = svans_bank;Uid=root;Pwd=;");
        string query = "START TRANSACTION; " +
        "CALL withdraw(@FromBankAccountId, @Amount, @ToBankAccountId);" +
        "INSERT INTO transactions(date_transaction, from_bank_account_id, to_bank_account_id, amount, transactions_type_id) " +
        "VALUES (@TransactionDate,@FromBankAccountId, @ToBankAccountId, @Amount, 4);" +
        "COMMIT;";
        connection.ExecuteScalar(query, param: transaction);
    }
    public List<Transactions> GetTransactions(int bankId)
    {
        
        using MySqlConnection connection = new MySqlConnection($"Server = localhost; Database = svans_bank;Uid=root;Pwd=;");
        string query = "SELECT transactions.amount AS 'Amount', transactions_type.name AS 'Type' "
        + "FROM transactions "
        + "INNER JOIN transactions_type "
        + "ON transactions_type.id = transactions.transactions_type_id "
        + "WHERE from_bank_account_id = @bankId;";
        List<Transactions> transactions = connection.Query<Transactions>(query, new{@bankId = bankId}).ToList();

        return transactions;

    }
    public int CountTransactions()
    {
        using MySqlConnection connection = new MySqlConnection($"Server = localhost; Database = svans_bank;Uid=root;Pwd=;");
        string query = "SELECT COUNT(*) FROM transactions";
        int transactions = connection.ExecuteScalar<int>(query);

        return transactions;

    }
}