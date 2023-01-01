using TYPES;
using DATABASE;
namespace LOGIC;
public interface IBankAccountService
{
    public List<BankAccount> GetAccounts(Customer customer);
    public void NewAccount(Customer customer, BankAccount bankAccount);
    public BankAccount GetTotalBalance(Customer customer);
}