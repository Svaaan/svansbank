using TYPES;
using DATABASE;
namespace LOGIC;
public interface ICustomerService
{
    public void AddCustomer(Customer customer, BankAccount bankAccount);
    public Customer GetCustomer(Customer customer);
}