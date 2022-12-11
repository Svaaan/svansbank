namespace UI;
internal class Program
{
    private static void Main(string[] args)
    {
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
                        answer = Console.ReadLine();

                    } while (LoginRegister < 1 || LoginRegister > 2);
                    if (LoginRegister == 1)
                    {
                        System.Console.WriteLine("Enter you email: ");
                        
                    }
                    else if (LoginRegister == 2)
                    {
                        
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

                    while (createMenu)
                    {
                        switch (becomeMemberMenu)
                        {

                        }
                    }

                    break;

                case 4:

                    System.Console.WriteLine("Svan's bank startade pga att jag var tvungen att komma på något och det var ett tag sen jag arbeta med siffror.");

                    break;

            }

        }

    }
}