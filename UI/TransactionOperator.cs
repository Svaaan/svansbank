using LOGIC;
using TYPES;
namespace UI;
public class TransactionOperator
{
    ITransactionService _iTransactionService;
    IBankAccountService _iBankAccountService;
    public TransactionOperator(ITransactionService iTransactionService, IBankAccountService iBankAccountService)
    {
        _iTransactionService = iTransactionService;
        _iBankAccountService = iBankAccountService;
    }
    public void MakeWithdrawal(Customer customer)
    {
        
        List<BankAccount> accounts = _iBankAccountService.GetAccounts(customer);
        foreach (BankAccount item in accounts)
        {
            System.Console.WriteLine(item.ToString());
        }
        bool success = false;
        int fromBankAccountId = 0;
        do
        {
            Console.WriteLine("Från konto: ");
            success = int.TryParse(Console.ReadLine(), out fromBankAccountId);
        } while (!success);

        int toBankAccountId = 0;
        do
        {
            Console.WriteLine("Till konto: ");
            success = int.TryParse(Console.ReadLine(), out toBankAccountId);
        } while (!success);

        decimal amount = 0;
        do
        {
            Console.WriteLine("Belopp: ");
            success = decimal.TryParse(Console.ReadLine(), out amount);
        } while (!success);
        Transactions transactions = new(fromBankAccountId, toBankAccountId, amount);
        _iTransactionService.WithdrawFromAccount(transactions);
    }
}
