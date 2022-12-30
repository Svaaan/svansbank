namespace TYPES;
public class BankAccount
{
    public int Id {get; set;}
    public string AccountNumber {get; set;}
    public string AccountType {get; set;}
    public decimal TotalBalance {get; set;}

    public BankAccount(string accountNumber, string accountType, decimal totalBalance)
    {
        this.AccountNumber = accountNumber;
        this.AccountType = accountType;
        this.TotalBalance = totalBalance;

    }
    public BankAccount()
    {

    }
    public override string ToString()
    {
        return $"{AccountType}\n{AccountNumber}\n{TotalBalance}";
    }

}