namespace TYPES;
public class Customer
{
    string Name {get; set;}
    string LastName {get; set;}
    string PersonalNumber {get; set;}
    string Mail {get; set;}
    string PhoneNumber {get; set;}
    string Location {get; set;}
    string StreetAdress {get; set;}
    int StreetNumber {get; set;}
    int PostalNumber {get; set;}
    string PassWord {get; set;}
    int CustomerId {get; set;}
    public Customer (string Name, string LastName, string PersonalNumber, string Mail, string PhoneNumber, string Location, string StreetAdress, int StreetNumber, int PostalNumber, string PassWord)
    {
        this.Name = Name;
        this.LastName = LastName;
        this.PersonalNumber = PersonalNumber;
        this.Mail = Mail;
        this.PhoneNumber = PhoneNumber;
        this.Location = Location;
        this.StreetAdress = StreetAdress;
        this.StreetNumber = StreetNumber;
        this.PostalNumber = PostalNumber;
        this.PassWord = PassWord;

    }



}
