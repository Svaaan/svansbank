using TYPES;
using DATABASE;
namespace LOGIC;
public class TransactionService : ITransactionService
{
    ITransactionHandeler _iTransactionHandeler;
    public TransactionService (ITransactionHandeler iTransactionHandeler)
    {
        _iTransactionHandeler = iTransactionHandeler;
    }
    public void WithdrawFromAccount(Transactions transactions)
    {
        _iTransactionHandeler.CreateInternalTransaction(transactions);

    }
    public void DepositToAccount(Transactions transactions)
    {
        
    }
    public List <Transactions> GetTransactions (int bankId)
    {
        return _iTransactionHandeler.GetTransactions(bankId);
    }
}