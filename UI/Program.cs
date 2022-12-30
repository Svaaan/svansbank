using LOGIC;
using TYPES;
using DATABASE;
namespace UI;

internal class Program
{
    private static void Main(string[] args)
    {
        BankAccountService bankAccountService = new(new BankAccountDB());
        TransactionService transactionsService = new(new TransactionDB());
        CustomerService customerService = new(new CustomerDB());
        LoginService loginService = new(new CustomerDB());
        RegistrationService registrationService = new(new CustomerDB());
        CreateAccountOperator createAccountOperator = new(registrationService);


        int LoginRegister = 0;

        int startOption = 0;
        int loggedInOption = 0;
        int becomeMemberMenu = 0;
        int serviceMenu = 0;
        bool menu = true;
        bool service = true;
        bool loggedInMenu = true;
        bool createMenu = true;
        string answer = string.Empty;
        while (menu)
        {
            System.Console.WriteLine("[1] Ditt Konto");
            System.Console.WriteLine("[2] Tjänst inloggning");
            System.Console.WriteLine("[3] Om Svan's bank");
            answer = Console.ReadLine();

            bool isNumber = int.TryParse(answer, out startOption);
            if (!isNumber)
            {
                System.Console.WriteLine("Only number input is valid");
            }

            switch (startOption)
            {
                case 1:

                    do
                    {
                        System.Console.WriteLine("[1] Logga in");
                        System.Console.WriteLine("[2] Skapa konto");
                        LoginRegister = int.Parse(Console.ReadLine());

                    } while (LoginRegister < 1 || LoginRegister > 2);
                    if (LoginRegister == 1)
                    {
                        CustomerPageOperator customerPageOperator = new (customerService, bankAccountService);
                        System.Console.WriteLine("Epost adress: ");
                        string email = Console.ReadLine();
                        System.Console.WriteLine("Lösenord: ");
                        string passWord = Console.ReadLine();
                        Customer customer = loginService.TryLogin(email, passWord);
                        if(customer != null) customerPageOperator.CustomerPage(customer);
                    }
                    else if (LoginRegister == 2)
                    {
                        createAccountOperator.CreateAccount();
                    }
                    break;

                case 2:

                    while (service)
                    {
                        switch (serviceMenu)
                        {

                        }
                    }

                    break;


                case 3:

                    System.Console.WriteLine("Svan's bank startade pga att jag var tvungen att komma på något och det var ett tag sen jag arbeta med siffror.");

                    break;

            }

        }

    }
}