namespace TYPES;
public class Customer
{
    string name {get; set;}
    string lastName {get; set;}
    string personalNumber {get; set;}
    string mail {get; set;}
    string phoneNumber {get; set;}
    string location {get; set;}
    string streetAdress {get; set;}
    int streetNumber {get; set;}
    int postalNumber {get; set;}
    string passWord {get; set;}

    public Customer (string name, string lastName, string personalNumber, string mail, string phoneNumber, string location, string streetAdress, int streetNumber, int postalNumber, string passWord)
    {
        this.name = name;
        this.lastName = lastName;
        this.personalNumber = personalNumber;
        this.mail = mail;
        this.phoneNumber = phoneNumber;
        this.location = location;
        this.streetAdress = streetAdress;
        this.streetNumber = streetNumber;
        this.postalNumber = postalNumber;
        this.passWord = passWord;

    }



}
