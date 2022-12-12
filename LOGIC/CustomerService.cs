using TYPES;
using DATABASE;
namespace LOGIC;
public class CustomerService : ICustomerService
{
   IcustomerHandeler _icustomerHandeler;
    public CustomerService(IcustomerHandeler icustomerHandeler)
    {
        _icustomerHandeler = icustomerHandeler;
    }
    public Customer AddCustomer(Customer customer)
    {
        return customer;
    }
    public Customer GetCustomer(Customer customer)
    {
       
       Customer getCustomer = new();

       return customer;    
               
    }
}
