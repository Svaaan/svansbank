class BankLoan
{
    decimal totalLoan {get; set;}
    string interestType {get; set;}
    decimal monthlyPayback {get; set;}

    public BankLoan(decimal totalLoan, string interestType, decimal monthlyPayback)
    {
        this.totalLoan = totalLoan;
        this.interestType = interestType;
        this.monthlyPayback = monthlyPayback;
    }
}