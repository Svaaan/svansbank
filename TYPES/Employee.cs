namespace TYPES;
public class Employee
{
    public int EmploymentNumber {get; set;}
    public string Name {get; set;}
    public string LastName {get; set;}
    public string Email {get; set;}

    public Employee (int EmploymentNumber, string Name, string LastName, string Email)
    {
        this.EmploymentNumber = EmploymentNumber;
        this.Name = Name;
        this.LastName = LastName; 
        this.Email = Email;
    }
    public Employee ()
    {
        
    }
}