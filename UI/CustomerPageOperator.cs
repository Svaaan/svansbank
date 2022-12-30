using LOGIC;
using TYPES;
using DATABASE;
namespace UI;
public class CustomerPageOperator
{
    ICustomerService _icustomerService;
    public CustomerPageOperator (ICustomerService iCustomerService)
    {
        _icustomerService = iCustomerService;
    }
    public void CustomerPage(Customer customer)
    {
        try
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
                    
                    
                        System.Console.WriteLine("Tryck på q för att avbryta och återgå till startmenyn");
                        System.Console.WriteLine("Från konto: "); //Finns det fler konton Får det adderas
                        answer = Console.ReadLine();
                        System.Console.WriteLine("Till konto: ");
                        answer = Console.ReadLine();
                        System.Console.WriteLine("Belopp: ");
                        amount = decimal.Parse(Console.ReadLine());
                        System.Console.WriteLine("Översikt");
                        System.Console.WriteLine("Skapa en överblick av valda inskrivna alternativ innan godkännande");
                        System.Console.WriteLine("Godkänn Överföring /true/false");
                

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

                        System.Console.WriteLine("Typ av konto som skall öppnas");
                        System.Console.WriteLine("Sparande konto");
                        System.Console.WriteLine("Överföring konto");
                        //Överförings konto är för att överföra belopp i kortare tid/tillfälligt
                        //Sparande konto är för att överföra belopp i längre perioder.
                        System.Console.WriteLine("Öppna konto till. //Skapa inner join");
                        answer = Console.ReadLine();
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
                        customer = _icustomerService.GetCustomer(customer);
                        
                        System.Console.WriteLine(customer.ToString());
                        //Enbart 2 styck redigerar kan göras på telefon nr och mail.
                        // Resten av ändringar skall begäras till customer_Service
                        //Skapa felhantering i CreateAccount så enkla misstag ej skickas till DB.
                        break;

                }
            }


        }
        catch
        {

        }

    }
}