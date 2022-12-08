namespace TYPES;
class Transactions
{
    public decimal Deposit {get; set;}
    public decimal Payment {get; set;}
    public decimal Withdrawals {get; set;}
    public decimal Transfer {get; set;}
    public decimal Amount {get; set;}
    public decimal TotalBalance {get; set;}
    //Filura på om du ska separera eller ha en egen table för withdrawals, deposits, payments för enskild id tracking;
}