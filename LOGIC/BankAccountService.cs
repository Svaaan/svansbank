using TYPES;
using DATABASE;
namespace LOGIC;

public class BankAccountService
{
    IBankAccountHandeler _iBankAccountHandeler;
    public BankAccountService (IBankAccountHandeler iBankAccountHandeler)
    {
        _iBankAccountHandeler = iBankAccountHandeler;
    }
    public void NewAccount()
    {

    }
    public List<BankAccount> GetAccounts(Customer customer)
    {
        return new List<BankAccount>();
    }
}