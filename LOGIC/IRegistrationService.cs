using TYPES;
using DATABASE;
namespace LOGIC;
public interface IRegistrationService
{
       public void CreateCustomerAccount(Customer customer, BankAccount bankAccount);
}