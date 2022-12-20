using Dapper;
using MySqlConnector;
using TYPES;
namespace DATABASE;
class BankAccountDB : IBankAccountHandeler
{
    public void CreateAccount(BankAccount bankAccount)
    {
        using MySqlConnection connection = new MySqlConnection($"Server = localhost; Database = svans_bank;Uid=rood;Pwd=;");
        string query = "START TRANSACTION; INSERT INTO bank_account (account_number, account_type, total_balance) " +
        " VALUES (@accountNumber, @AccountType, @TotalBalance); " +
        "SET @bank_account_id := LAST_INSERT_ID(); " +
        "INSERT INTO customer_to_account(bank_account_id, customer_id) " +
        "VALUES (@bank_account_id, );COMMIT;";
        connection.ExecuteScalar(query, param: bankAccount);
    }
    public List <BankAccount> GetBankAccounts (BankAccount bankAccount)
    {
        
        List <BankAccount> getAccounts = new();
        using MySqlConnection connection = new MySqlConnection($"Server = localhost; Database = svans_bank;Uid=rood;Pwd=;");
        string query = "SELECT id AS 'Id', account_number AS 'AccountNumber', account_type AS 'AccountType', total_balance AS 'TotalBalance' FROM bank_account;";
            getAccounts = connection.Query<BankAccount>(query).ToList();
            return getAccounts;
    }
    //INSERT INTO `customer_account`(`bank_account_id`, `customer_id`) VALUES (1,1)
    //START TRANSACTION;


}