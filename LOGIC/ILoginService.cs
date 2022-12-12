using TYPES;
using DATABASE;
namespace LOGIC;
public interface ILoginService
{
    public Customer AddCustomer(Customer customer);
    public Customer TryLogin (string email, string passWord);

}