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
    public void AddCustomer(Customer customer, BankAccount bankAccount)
    {
        _icustomerHandeler.AddCustomer(customer, bankAccount);
    }
    public Customer GetCustomer(Customer customer)
    {
      List <Customer> customers = _icustomerHandeler.GetCustomer();  
      foreach (Customer item in customers)
      {
       if(item.Id == customer.Id)
       {
          customer = item;
       }  
      }    
      return customer;
    }
}
