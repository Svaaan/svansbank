namespace TYPES;
public class BankAccount
{
    public int Id {get; set;}
    public int AccountNumber {get; set;}
    public string AccountType {get; set;}
    public decimal TotalBalance {get; set;}

    public BankAccount(int accountNumber, string accountType, decimal totalBalance)
    {
        this.AccountNumber = accountNumber;
        this.AccountType = accountType;
        this.TotalBalance = totalBalance;

    }
}