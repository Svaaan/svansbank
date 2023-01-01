using LOGIC;
using TYPES;
using DATABASE;
namespace UI;
public class CustomerPageOperator
{
    ICustomerService _iCustomerService;
    IBankAccountService _iBankAccountService;
    ITransactionService _iTransactionService;
    public CustomerPageOperator(ICustomerService iCustomerService, IBankAccountService iBankAccountService, ITransactionService iTransactionService)
    {
        _iBankAccountService = iBankAccountService;
        _iCustomerService = iCustomerService;
        _iTransactionService = iTransactionService;
    }
    public void CustomerPage(Customer customer)
    {
        decimal totalBalance = 0;
        int customerPage = 0;
        string answer = string.Empty;
        decimal amount = 0;
        bool customerMainMenu = true;
        bool approveTransaction = true;
        bool disapproveTransaction = false;

        while (customerMainMenu)
        {
            BankAccount transactionAccount = new();
            // hämta saldot till transactionaccount til totalbalance

            System.Console.WriteLine("Ditt saldo: " + totalBalance);
            System.Console.WriteLine("[1] Betala");
            System.Console.WriteLine("[2] Överför egna konton");
            System.Console.WriteLine("[3] Öppna nytt konto");
            System.Console.WriteLine("[4] Förfråga lån");
            System.Console.WriteLine("[5] Översikt mina transaktioner");
            System.Console.WriteLine("[6] KontoInformation");

            answer = Console.ReadLine();

            bool isNumber = int.TryParse(answer, out customerPage);
            if (!isNumber)
            {
                System.Console.WriteLine("Only number input is valid");
            }


            switch (customerPage)
            {
                case 1:


                TransactionOperator transactionOperator = new(_iTransactionService, _iBankAccountService);
                transactionOperator.MakeWithdrawal(customer);
                    //If true begär transaktion
                    break;
                case 2:
                    System.Console.WriteLine("Från konto");
                    answer = Console.ReadLine();
                    System.Console.WriteLine("Till konto");
                    answer = Console.ReadLine();
                    System.Console.WriteLine("Belopp");
                    amount = decimal.Parse(Console.ReadLine());
                    System.Console.WriteLine("Översikt");
                    System.Console.WriteLine("Skapa en överblick av valda inskrivna alternativ innan godkännande");
                    System.Console.WriteLine("Godkänn Överföring /true/false");
                    break;
                case 3:
                  NewBankAccount(customer);
                    break;
                case 4:
                    //Rad olika förfrågningar som krävs för att godkänna lån
                    //Förfrågan skall skickas till Service_login för godkännade
                    //If true == skapa ett lån godkännande 
                    System.Console.WriteLine();
                    break;
                case 5:
                    //Behöver göra separata statiska metoder för 4 och och 5.
                    break;
                case 6:
                    //Hämta konto information ifrån GetCustomer. 
                    customer = _iCustomerService.GetCustomer(customer);

                    System.Console.WriteLine(customer.ToString());

                    List<BankAccount> accounts = _iBankAccountService.GetAccounts(customer);
                    foreach (BankAccount item in accounts)
                    {
                        System.Console.WriteLine(item.ToString());
                    }
                    //Enbart 2 styck redigerar kan göras på telefon nr och mail.
                    // Resten av ändringar skall begäras till customer_Service
                    //Skapa felhantering i CreateAccount så enkla misstag ej skickas till DB.
                    break;

            }
        }
    }

    public void NewBankAccount(Customer customer)
    {
        BankAccount newAccount = new(Tools.BankAccountRandomNumberGenerator(), "Sparkonto", 0);
        _iBankAccountService.NewAccount(customer, newAccount);

        System.Console.WriteLine("Sparkonto skapats\n" + newAccount.ToString());
        Console.ReadLine();
    }
}