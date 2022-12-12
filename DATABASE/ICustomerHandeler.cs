using TYPES;
namespace DATABASE;
public interface IcustomerHandeler
{
    public int AddCustomer(Customer customer, BankAccount bankAccount);
    public List<Customer> GetCustomer();
    public Customer GetCustomerByLogIn(string mail, string passWord);
}