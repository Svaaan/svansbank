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
    public Customer (string name, string lastName, string personalNumber, string mail, string phoneNumber, string city, string streetAdress, int streetNumber, int postalNumber, string passWord)
    {
        this.Name = name;
        this.LastName = lastName;
        this.PersonalNumber = personalNumber;
        this.Mail = mail;
        this.PhoneNumber = phoneNumber;
        this.City = city;
        this.StreetAdress = streetAdress;
        this.StreetNumber = streetNumber;
        this.PostalNumber = postalNumber;
        this.PassWord = passWord;

    }
    public Customer ()
    {

    }

    public override string ToString()
    {
        return $"Namn: {Name} {LastName}\nTelefonnummer: {PhoneNumber}\nE-Postadress: {Mail}\nPersonnummer: {PersonalNumber}\nStad: {City}\nAdress: {StreetAdress} {StreetNumber}\nPostnummer: {PostalNumber}";
        
    }



}
