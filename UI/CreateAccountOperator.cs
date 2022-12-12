using LOGIC;
using TYPES;
using DATABASE;
namespace UI;
public class CreateAccountOperator
{
    IRegistrationService _iRegistrationService;

    public CreateAccountOperator (IRegistrationService iregistrationService)
    {
        _iRegistrationService = iregistrationService;
    }
    public void CreateAccount()
    {
        Customer customer1 = new();
        BankAccount bankAccount1 = new();

        try
        {
            while (true)
            {
                System.Console.WriteLine("Namn:");
                customer1.Name = Console.ReadLine();
                System.Console.WriteLine("Efternamn:");
                customer1.LastName = Console.ReadLine();
                System.Console.WriteLine("Person nummer:");
                customer1.PersonalNumber = Console.ReadLine();
                System.Console.WriteLine("E-Mail");
                customer1.Mail = Console.ReadLine();
                System.Console.WriteLine("Stad");
                customer1.City = Console.ReadLine();
                System.Console.WriteLine("Gatu Adress:");
                customer1.StreetAdress = Console.ReadLine();
                System.Console.WriteLine("Gatu nummer:");
                customer1.StreetNumber = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Post nummer:");
                customer1.PostalNumber = int.Parse(Console.ReadLine());
                string passWord = string.Empty;
                string passWord2 = string.Empty;
                do
                {
                    System.Console.WriteLine("Lösenord:");
                    passWord = Console.ReadLine();
                    System.Console.WriteLine("bekräfta lösenord:");
                    passWord2 = Console.ReadLine();
                }while (passWord != passWord2);
                customer1.PassWord = passWord;
                customer1.BankId = 1;

                bankAccount1.AccountType = "Transaktionskonto";
                bankAccount1.AccountNumber = RandomNumberGenerator();
                bankAccount1.TotalBalance = 0;
                Console.WriteLine("Skapar bankkonto");
                _iRegistrationService.CreateCustomerAccount(customer1, bankAccount1);
                Console.WriteLine("Skapat bankkonto!");
                break;
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    public static string RandomNumberGenerator()
    {
         Random random = new Random();
         int randomNumber = random.Next(10000, 99999);

         Random random1 = new Random();
         int randomNumber1 = random.Next(1000,9999);

         string accountNumber = (randomNumber + " - " + randomNumber1);

         return accountNumber;
    }
}