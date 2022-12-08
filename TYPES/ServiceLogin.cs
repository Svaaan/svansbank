namespace TYPES;
class ServiceLogin
{
    int employementNumber {get; set;}
    string name {get; set;}
    string lastName {get; set;}
    string email {get; set;}

    public ServiceLogin (int employementNumber, string name, string lastName, string email)
    {
        this.employementNumber = employementNumber;
        this.name = name;
        this.lastName = lastName; 
        this.email = email;
    }
}