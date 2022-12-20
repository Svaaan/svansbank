using Dapper;
using MySqlConnector;
using TYPES;
namespace DATABASE;
public interface IBankAccountHandeler
{
    public void CreateAccount(BankAccount bankAccount);

    public List <BankAccount> GetBankAccounts (BankAccount bankAccount);
  
}