using TYPES;
using DATABASE;
namespace LOGIC;
public interface IBankAccountService
{
    public List<BankAccount> GetAccounts(Customer customer);

    public void NewAccount();
}