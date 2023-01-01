namespace TYPES;
public class Transactions
{
    // public decimal Deposit {get; set;}
    // public decimal Payment {get; set;}
    // public decimal Withdrawals {get; set;}
    // public decimal Transfer {get; set;}
    public int TransactionId {get;set;}
    public int CustomerId{get;set;}
    public int FromBankAccountId{get;set;}
    public int ToBankAccountId{get;set;}
    public decimal Amount {get; set;}
    public DateTime TransactionDate{get;set;}

    public Transactions(int fromBankAccountId, int toBankAccountId, decimal amount)
    {
        FromBankAccountId = fromBankAccountId;
        ToBankAccountId = toBankAccountId;
        Amount = amount;
        TransactionDate = DateTime.Now;
    }
    public override string ToString()
    {
        return $"{Amount}";
    }
    //Filura på om du ska separera eller ha en egen table för withdrawals, deposits, payments för enskild id tracking;
}