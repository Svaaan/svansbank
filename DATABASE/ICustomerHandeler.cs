using TYPES;
namespace DATABASE;
public interface IcustomerHandeler
{
    public int AddCustomer(Customer customer, BankAccount bankAccount);
    public List<Customer> GetCustomer();
    public Customer GetCustomerByLogIn(string mail, string passWord);
    public int UpdateEmail(Customer customer, string Email);
    public int UpdatePhoneNumber(Customer customer, string PhoneNumber);
    public int UpdatePassWord(Customer customer, string PassWord);
}