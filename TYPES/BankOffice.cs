namespace TYPES;
public class BankOffice
{
    //name, location, street adress, streetNumber, postalAdress
    public int BankId {get; set;}
    public string BankName {get; set;}
    public string BankLocation {get; set;}
    public string BankStreetAdress {get; set;}
    public int BankStreetNumber {get; set;}
    public int BankPostalNumber {get; set;}

    public BankOffice (string BankName, string BankLocation, string BankStreetAdress, int BankstreetNumber, int BankPostalNumber)
    {
        this.BankName = BankName;
        this.BankLocation = BankLocation;
        this.BankStreetAdress = BankStreetAdress;
        this.BankStreetNumber = BankStreetNumber;
        this.BankPostalNumber = BankPostalNumber;
    }
    public BankOffice()
    {

    }
    public override string ToString()
    {
        return $"{BankName}\n{BankLocation}\n{BankStreetAdress} {BankStreetNumber} \n{BankPostalNumber}";
    }

}