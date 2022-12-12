namespace TYPES;
class BankLoan
{
    public decimal totalLoan {get; set;}
    public string interestType {get; set;}
    public decimal monthlyPayback {get; set;}

    public BankLoan(decimal totalLoan, string interestType, decimal monthlyPayback)
    {
        this.totalLoan = totalLoan;
        this.interestType = interestType;
        this.monthlyPayback = monthlyPayback;
    }
}