namespace TYPES;
public class BankAccount
{
    int Id {get; set;}
    int AccountNumber {get; set;}
    string AccountType {get; set;}
    decimal TotalBalance {get; set;}

    public BankAccount(int accountNumber, string accountType, decimal totalBalance)
    {
        this.AccountNumber = accountNumber;
        this.AccountType = accountType;
        this.TotalBalance = totalBalance;

    }
}