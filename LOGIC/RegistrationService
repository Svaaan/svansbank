using TYPES;
using DATABASE;
namespace LOGIC;
public class RegistrationService : IRegistrationService
{
     IcustomerHandeler _icustomerHandeler;
    public RegistrationService(IcustomerHandeler icustomerHandeler)
    {
        _icustomerHandeler = icustomerHandeler;
    }
    public void CreateCustomerAccount(Customer customer, BankAccount bankAccount)
    {
        _icustomerHandeler.AddCustomer(customer, bankAccount);

    }
}