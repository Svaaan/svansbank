using LOGIC;
using TYPES;
using DATABASE;
namespace UI;
public class CustomerPageOperator
{
    public void CustomerPage()
    {
        try
        {
            int customerPage = 0;
            string answer = string.Empty;
            while (true)
            {
                System.Console.WriteLine("Ditt saldo:");
                System.Console.WriteLine("[1] Betala");
                System.Console.WriteLine("[2] Överför egna konton");
                System.Console.WriteLine("[3] Öppna nytt konto");
                System.Console.WriteLine("[4] Förfråga lån");
                System.Console.WriteLine("[5] KontoInformation");

                answer = Console.ReadLine();

                bool isNumber = int.TryParse(answer, out customerPage);
                if (!isNumber)
                {
                    System.Console.WriteLine("Only number input is valid");
                }


                switch (customerPage)
                {
                    case 1:
                        System.Console.WriteLine("Från Konto: "); //Finns det fler konton Får det adderas
                        answer = Console.ReadLine();
                        System.Console.WriteLine("Till Konto: ");
                        answer = Console.ReadLine();
                        System.Console.WriteLine("Belopp: ");
                        decimal amount = decimal.Parse(Console.ReadLine());
                        System.Console.WriteLine("Översikt");
                        System.Console.WriteLine("Skapa en överblick av valda inskrivna alternativ innan godkännande");
                        System.Console.WriteLine("Godkänn Överföring /true/false");
                        //If true begär transaktion

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;

                }
            }


        }
        catch
        {

        }

    }
}