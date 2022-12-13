using TYPES;
using DATABASE;
namespace LOGIC;
public interface ICustomerService
{
    public Customer AddCustomer(Customer customer);
    public void GetCustomer(Customer customer);
}