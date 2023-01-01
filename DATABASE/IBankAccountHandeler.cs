using Dapper;
using MySqlConnector;
using TYPES;
namespace DATABASE;
public interface IBankAccountHandeler
{
    public void CreateAccount(BankAccount bankAccount, Customer customer);

    public List <BankAccount> GetBankAccounts ();

    public List<BankAccount> PersonalBankAccounts(Customer customer);
  
}