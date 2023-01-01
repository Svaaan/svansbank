
namespace LOGIC;
public class Tools
{
    public static string BankAccountRandomNumberGenerator()
    {
        Random random = new Random();
        int randomNumber = random.Next(10000, 99999);

        Random random1 = new Random();
        int randomNumber1 = random.Next(1000, 9999);

        string accountNumber = (randomNumber + "-" + randomNumber1);

        return accountNumber;
    }
    public static string EmployeeRandomNumberGenerator ()
    {
        Random random = new Random();
        int randomEmployeeNumber = random.Next(10000, 99999);

        string employeeNumber = (randomEmployeeNumber.ToString());

        return employeeNumber;


    }
}