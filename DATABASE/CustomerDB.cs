﻿using DATABASE;
using Dapper;
using MySqlConnector;
using TYPES;
namespace DATABASE;
public class CustomerDB : IcustomerHandeler
{
    public List<Customer> customer = new();
    public int AddCustomer(Customer customer, BankAccount  bankAccount)
    {
        using (MySqlConnection connection = new MySqlConnection($"Server = localhost; Database = svans_bank;Uid=root;Pwd=;Allow User Variables=true;"))
        {
            int rows = 0;
            string query = "START TRANSACTION;" +
            "INSERT INTO customer(name, last_name, personal_number, email, " +
            " phone_number, city, street_adress, " +
            " street_number, postal_number, pass_word, bank_id) " +
            "VALUES(@Name, @LastName, @PersonalNumber, @Mail, @PhoneNumber, @City, " +
            " @StreetAdress, @StreetNumber, @PostalNumber, @PassWord, @BankId);" +
            "SET @customer_id := LAST_INSERT_ID(); " +
            "INSERT INTO bank_account (account_number, account_type, total_balance) " +
            "VALUES (@accountNumber, @AccountType, @TotalBalance); " +
            "SET @bank_account_id := LAST_INSERT_ID(); " +
            "INSERT INTO customer_to_account(bank_account_id, customer_id) " +
            "VALUES (@bank_account_id,@customer_id);COMMIT;";
            rows = connection.ExecuteScalar<int>(query, new{@Name = customer.Name, @LastName = customer.LastName, @PersonalNumber = customer.PersonalNumber,@Mail = customer.Mail,@PhoneNumber = customer.PhoneNumber, @City = customer.City, @StreetAdress = customer.StreetAdress, @StreetNumber = customer.StreetNumber, @PostalNumber = customer.PostalNumber, @PassWord = customer.PassWord,@BankId = @customer.BankId, @AccountType = bankAccount.AccountType, @AccountNumber = bankAccount.AccountNumber, @TotalBalance = bankAccount.TotalBalance});
            return rows;
        }
    }
     
    public List<Customer> GetCustomer()
    {
        List<Customer> getCustomer = new();
        //ska göra sökningfunktion i c#

        using (MySqlConnection connection = new MySqlConnection($"Server=localhost;Database=svans_bank;Uid=root;Pwd=;"))
        {
            string query = "SELECT id AS 'Id', name AS 'Name', last_name AS 'LastName', personal_number AS 'PersonalNumber', city AS 'City', street_adress AS 'StreetAdress', street_number AS 'StreetNumber', postal_number AS 'PostalNumber', pass_word AS 'PassWord', email AS 'Mail', phone_number AS 'PhoneNumber' FROM customer;";
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
     public int UpdateEmail(Customer customer, string Email)
    {
        int rows = 0;
        using (MySqlConnection connection = new MySqlConnection($"Server=localhost;Database=Svans_bank;Uid=root;Pwd=;"))
        {
            string query = "UPDATE customer SET email = @Email WHERE id = @id";
            rows = connection.ExecuteScalar<int>(query, param: new { @email= Email, @id = customer.Id });
        }
        return rows;
    }
     public int UpdatePhoneNumber(Customer customer, string phoneNumber)
    {
        int rows = 0;
        using (MySqlConnection connection = new MySqlConnection($"Server=localhost;Database=Svans_bank;Uid=root;Pwd=;"))
        {
            string query = "UPDATE customer SET phone_number = @PhoneNumber WHERE id = @id";
            rows = connection.ExecuteScalar<int>(query, param: new { @phone_number = phoneNumber, @id = customer.Id });
        }
        return rows;
    }
    public int UpdatePassWord(Customer customer, string passWord)
    {
        int rows = 0;
        using (MySqlConnection connection = new MySqlConnection($"Server=localhost;Database=Svans_bank;Uid=root;Pwd=;"))
        {
            string query = "UPDATE customer SET pass_word = @PassWord WHERE id = @id";
            rows = connection.ExecuteScalar<int>(query, param: new { @pass_word = passWord, @id = customer.Id });
        }
        return rows;
    }







}
