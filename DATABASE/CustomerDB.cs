﻿using DATABASE;
using Dapper;
using MySqlConnector;
using TYPES;
namespace DATABASE;
class Customer
{
    public List<Customer> customer = new();
    public int AddCustomer(Customer customer)
    {
        using (MySqlConnection connection = new MySqlConnection($"Server = localhost; Database = svans_bank;Uid=rood;Pwd=;"))
        {
            int rows = 0;
            string query = "INSERT INTO customer(name, last_name, personal_number ,mail, phone_number, location, street_adress, street_number, postal_number, pass_word , bank_office_id)VALUES(@Name, @LastName, @PersonalNumber, @Mail, @PhoneNumber, @Location, @StreetAdress, @StreetNumber, @PostalNumber, @PassWord ,@BankOfficeId);";
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
            string query = "SELECT id AS 'CustomerId', name AS 'Name', last_name AS 'LastName', personal_number AS 'PersonalNumber', location AS 'Location', street_adress AS 'StreetAdress', street_number AS 'StreetNumber', postal_number AS 'PostalNumber', pass_word AS 'PassWord' FROM customer;";
            getCustomer = connection.Query<Customer>(query).ToList();
            return getCustomer;
        }
    }
    





}
