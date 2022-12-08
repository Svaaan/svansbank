using Dapper;
using MySqlConnector;
using Dapper;
using MySqlConnector;
using TYPES;
namespace DATABASE;

class TransactionDB
{
    public void CreateWithdrawalTransaction(Transactions transaction)
    {
        using MySqlConnection connection = new MySqlConnection($"Server = localhost; Database = svans_bank;Uid=rood;Pwd=;");
        string query = "START TRANSACTION; " +
        "INSERT INTO transactions(customer_id, date_transaction, bank_account_id, amount) "+
        "VALUES (@CustomerId,@TransactionDate,@BankAccountId,@Amount); " +
        "UPDATE bank_account SET total_balance = total_balance - @Amount " +
        "WHERE id = @BankAccountId; " + //där aktuella bank_account_idt är ..
        "COMMIT; ";
    }
}