using TYPES;
using DATABASE;
namespace LOGIC;

public class BankAccountService : IBankAccountService
{
    IBankAccountHandeler _iBankAccountHandeler;
    public BankAccountService(IBankAccountHandeler iBankAccountHandeler)
    {
        _iBankAccountHandeler = iBankAccountHandeler;
    }
    public void NewAccount(Customer customer, BankAccount bankAccount)
    {
        _iBankAccountHandeler.CreateBankAccount(bankAccount, customer);
    }
    public List<BankAccount> GetAccounts(Customer customer)
    {
        List<BankAccount> accounts = _iBankAccountHandeler.PersonalBankAccounts(customer);
        return accounts;
    }

    public BankAccount GetTransactionsAccount(Customer customer)
    {
        List<BankAccount> accounts = _iBankAccountHandeler.PersonalBankAccounts(customer);
        BankAccount bankAccount = new();
        foreach (BankAccount item in accounts)
        {
            if (item.AccountType == "Transaktionskonto")
            {
                bankAccount = item;
            }
        }
        return bankAccount;
    }

}