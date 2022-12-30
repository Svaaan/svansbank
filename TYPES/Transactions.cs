namespace TYPES;
public class Transactions
{
    // public decimal Deposit {get; set;}
    // public decimal Payment {get; set;}
    // public decimal Withdrawals {get; set;}
    // public decimal Transfer {get; set;}
    public int TransactionId {get;set;}
    public int CustomerId{get;set;}
    public int BankAccountId{get;set;}
    public decimal Amount {get; set;}
    public DateTime TransationDate{get;set;}

    public Transactions(decimal amount)
    {
        
        Amount = amount;
        TransationDate = DateTime.Now;
    }
    public override string ToString()
    {
        return $"{Amount}";
    }
    //Filura på om du ska separera eller ha en egen table för withdrawals, deposits, payments för enskild id tracking;
}