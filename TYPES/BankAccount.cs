namespace TYPES;
class BankAccount
{
    int accountNumber {get; set;}
    string accountType {get; set;}
    decimal totalBalance {get; set;}

    public BankAccount(int accountNumber, string accountType, decimal totalBalance)
    {
        this.accountNumber = accountNumber;
        this.accountType = accountType;
        this.totalBalance = totalBalance;

    }
}