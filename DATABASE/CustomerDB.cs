using DATABASE;
using Dapper;
using MySqlConnector;
using TYPES;
namespace DATABASE;
public class CustomerDB : IcustomerHandeler
{
    public List<Customer> customer = new();
    public int AddCustomer(Customer customer, BankAccount  bankAccount)
    {
        using (MySqlConnection connection = new MySqlConnection($"Server = localhost; Database = svans_bank;Uid=rood;Pwd=;"))
        {
            int rows = 0;
            string query = "START TRANSACTION;" +
            "INSERT INTO customer(name, last_name, personal_number, mail, " +
            " phone_number, city, street_adress, " +
            " street_number, postal_number, pass_word, bank_office_id) " +
            "VALUES(@Name, @LastName, @PersonalNumber, @Mail, @PhoneNumber, @City, " +
            " @StreetAdress, @StreetNumber, @PostalNumber, @PassWord, @BankOfficeId);" +
            "SET @customer_id := LAST_INSERT_ID(); " +
            "INSERT INTO bank_account (account_number, account_type, total_balance) " +
            "VALUES (@accountNumber, @AccountType, @TotalBalance); " +
            "SET @bank_account_id := LAST_INSERT_ID(); " +
            "INSERT INTO customer_to_account(bank_account_id, customer_id) " +
            "VALUES (@bank_account_id,@customer_id);COMMIT;";
            rows = connection.ExecuteScalar<int>(query, param: customer);
            return rows;
        }
    }
    public List<Customer> GetCustomer()
    {
        List<Customer> getCustomer = new();
        //ska göra sökningfunktion i c#

        using (MySqlConnection connection = new MySqlConnection($"Server=localhost;Database=svans_bank;Uid=root;Pwd=;"))
        {
            string query = "SELECT id AS 'CustomerId', name AS 'Name', last_name AS 'LastName', personal_number AS 'PersonalNumber', city AS 'City', street_adress AS 'StreetAdress', street_number AS 'StreetNumber', postal_number AS 'PostalNumber', pass_word AS 'PassWord' FROM customer;";
            getCustomer = connection.Query<Customer>(query).ToList();
            return getCustomer;
        }
    }
       public Customer GetCustomerByLogIn(string email, string passWord)
    {
        Customer customer = new Customer();

        using (MySqlConnection connection = new MySqlConnection($"Server=localhost;Database=svans_bank;Uid=root;Pwd=;"))
        {
            string query = "SELECT id AS 'Id', name AS 'Name', last_name AS 'LastName', personal_number AS 'PersonalNumber', city AS 'City', street_adress AS 'StreetAdress', street_number AS 'StreetNumber', postal_number AS 'PostalNumber', pass_word AS 'PassWord' FROM customer WHERE email = @email AND pass_word = @PassWord;";
            customer = connection.QuerySingle<Customer>(query, new{@email = email, @PassWord = passWord});
            return customer;
        }
    }






}
