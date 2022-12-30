using TYPES;
using DATABASE;
namespace LOGIC;

public class BankAccountService : IBankAccountService
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
        List<BankAccount> accounts = _iBankAccountHandeler.PersonalBankAccounts(customer);
        return accounts;
    }
}