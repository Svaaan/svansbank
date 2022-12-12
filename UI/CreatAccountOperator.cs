using LOGIC;
using TYPES;
using DATABASE;
namespace UI;
public class CreateAccountOperator
{
    public void CreateAccount(Customer customer)
    {

        try
        {
            while (true)
            {
                System.Console.WriteLine("Namn:");
                string name = Console.ReadLine();
                System.Console.WriteLine("Efternamn:");
                string lastName = Console.ReadLine();
                System.Console.WriteLine("Person nummer:");
                string personalNumber = Console.ReadLine();
                System.Console.WriteLine("E-Mail");
                string mail = Console.ReadLine();
                System.Console.WriteLine("Stad");
                string location = Console.ReadLine();
                System.Console.WriteLine("Gatu Adress:");
                string streeAdress = Console.ReadLine();
                System.Console.WriteLine("Gatu nummer:");
                int city = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Post nummer:");
                int postNummer = int.Parse(Console.ReadLine());
                string passWord = string.Empty;
                string passWord2 = string.Empty;
                do
                {
                    System.Console.WriteLine("Lösenord:");
                    passWord = Console.ReadLine();
                    System.Console.WriteLine("bekräfta lösenord:");
                    passWord2 = Console.ReadLine();
                }while (passWord != passWord2);
            }
        }
        catch
        {

        }

    }
}