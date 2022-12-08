namespace UI;
class Startmenu
{
    public void StartMenu()
    {
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
            System.Console.WriteLine("[1] Logga in");
            System.Console.WriteLine("[2] Tjänst inloggning");
            System.Console.WriteLine("[3] Starta ditt medlemskap");
            System.Console.WriteLine("[4] Om Svan's bank");
            answer = Console.ReadLine();

            bool isNumber = int.TryParse(answer, out startOption);
            if (!isNumber)
            {
                System.Console.WriteLine("Only number input is valid");
            }

            switch (startOption)
            {
                case 1:

                while(loggedInMenu)
                {
                    switch (loggedInOption)
                    {

                    }
                }

                break;

                case 2:

                  while (service)
                {
                    switch(serviceMenu)
                    {
                        
                    }
                }

                break;

                case 3:

                while(createMenu)
                {
                    switch(becomeMemberMenu)
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