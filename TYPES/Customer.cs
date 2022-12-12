namespace TYPES;
public class Customer
{
    public int Id{get;set;}
    public string Name {get; set;}
    public string LastName {get; set;}
    public string PersonalNumber {get; set;}
    public string Mail {get; set;}
    public string PhoneNumber {get; set;}
    public string City {get; set;}
    public string StreetAdress {get; set;}
    public int StreetNumber {get; set;}
    public int PostalNumber {get; set;}
    public string PassWord {get; set;}
    public int BankId {get; set;}
    public Customer (string Name, string LastName, string PersonalNumber, string Mail, string PhoneNumber, string City, string StreetAdress, int StreetNumber, int PostalNumber, string PassWord)
    {
        this.Name = Name;
        this.LastName = LastName;
        this.PersonalNumber = PersonalNumber;
        this.Mail = Mail;
        this.PhoneNumber = PhoneNumber;
        this.City = City;
        this.StreetAdress = StreetAdress;
        this.StreetNumber = StreetNumber;
        this.PostalNumber = PostalNumber;
        this.PassWord = PassWord;

    }
    public Customer ()
    {

    }



}
