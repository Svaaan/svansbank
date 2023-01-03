using Dapper;
using MySqlConnector;
using TYPES;
namespace DATABASE;
public interface IBankAccountHandeler
{
    public void CreateBankAccount(BankAccount bankAccount, Customer customer);
    public List<BankAccount> PersonalBankAccounts(Customer customer);
  
}