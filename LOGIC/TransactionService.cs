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
    public void DepositToAccount(decimal Amount)
    {
        
    }
}