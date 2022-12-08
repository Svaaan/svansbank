using Dapper;
using MySqlConnector;
using TYPES;
namespace DATABASE;
class BankAccountDB
{
    public void CreateAccount(BankAccount bankAccount)
    {
        using MySqlConnection connection = new MySqlConnection($"Server = localhost; Database = svans_bank;Uid=rood;Pwd=;");
        string query = "START TRANSACTION; INSERT INTO bank_account (account_number, account_type, total_balance) " +
        " VALUES ('1342-5656', 'Sparkonto', 0); " +
        "SET @bank_account_id := LAST_INSERT_ID(); " +
        "INSERT INTO customer_account(bank_account_id, customer_id) " +
        "VALUES (@bank_account_id,1);COMMIT;";
        connection.ExecuteScalar(query, param: bankAccount);
    }
    //INSERT INTO `customer_account`(`bank_account_id`, `customer_id`) VALUES (1,1)
    //START TRANSACTION;


}