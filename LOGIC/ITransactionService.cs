using TYPES;
using DATABASE;
namespace LOGIC;
public interface ITransactionService
{
    public void WithdrawFromAccount(Transactions transactions);

    public void DepositToAccount(Transactions transactions);

    public List <Transactions> GetTransactions (int bankId);
}