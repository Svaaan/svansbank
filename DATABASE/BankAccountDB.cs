using Dapper;
using MySqlConnector;
using TYPES;
namespace DATABASE;
public class BankAccountDB : IBankAccountHandeler
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
    public List<BankAccount> GetBankAccounts()
    {

        List<BankAccount> getAccounts = new();
        using MySqlConnection connection = new MySqlConnection($"Server = localhost; Database = svans_bank;Uid=root;Pwd=;");
        string query = "SELECT id AS 'Id', account_number AS 'AccountNumber', account_type AS 'AccountType', total_balance AS 'TotalBalance' FROM bank_account;";
        getAccounts = connection.Query<BankAccount>(query).ToList();
        return getAccounts;
    }
    //INSERT INTO `customer_account`(`bank_account_id`, `customer_id`) VALUES (1,1)
    //START TRANSACTION;
    public List<BankAccount> PersonalBankAccounts(Customer customer)
    {
        List<BankAccount> getAccounts = new();
        using MySqlConnection connection = new MySqlConnection($"Server = localhost; Database = svans_bank;Uid=root;Pwd=;");
        string query = "SELECT ba.id, ba.account_number as 'AccountNumber', ba.account_type as 'AccountType', ba.total_balance AS 'TotalBalance' " +
                        "FROM bank_account ba " +
                         "INNER JOIN customer_to_account cta " +
                        "ON ba.id = cta.bank_account_id " +
                        "WHERE cta.customer_id = @id; ";
        getAccounts = connection.Query<BankAccount>(query, new{@id = customer.Id}).ToList();
        return getAccounts;
    }

}