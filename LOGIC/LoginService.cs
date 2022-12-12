using TYPES;
using DATABASE;
namespace LOGIC;
public class LoginService : ILoginService
{
    IcustomerHandeler _icustomerHandeler;
    public LoginService(IcustomerHandeler icustomerHandeler)
    {
        _icustomerHandeler = icustomerHandeler;
    }
    public Customer TryLogin (string email, string passWord)
    {
        //skicka in mail och password till metoden i databas som kollar om det finns
        //och som isåfall returnerar en customer och den sätts hit
        Customer customer = _icustomerHandeler.GetCustomerByLogIn(email, passWord);
        //catcha System.InvalidOperationException
        return customer;
    }
    
}
