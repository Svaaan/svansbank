namespace TYPES;
class ServiceLogin
{
    public int employementNumber {get; set;}
    public string name {get; set;}
    public string lastName {get; set;}
    public string email {get; set;}

    public ServiceLogin (int employementNumber, string name, string lastName, string email)
    {
        this.employementNumber = employementNumber;
        this.name = name;
        this.lastName = lastName; 
        this.email = email;
    }
}