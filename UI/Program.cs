﻿internal class Program
{
    private static void Main(string[] args)
    {
        string title = @"
              ______   __     __   ______   __    __  __  ______         _______    ______   __    __  __    __ 
             /      \ /  |   /  | /      \ /  \  /  |/  |/      \       /       \  /      \ /  \  /  |/  |  /  |
            /$$$$$$  |$$ |   $$ |/$$$$$$  |$$  \ $$ |$$//$$$$$$  |      $$$$$$$  |/$$$$$$  |$$  \ $$ |$$ | /$$/ 
            $$ \__$$/ $$ |   $$ |$$ |__$$ |$$$  \$$ |$/ $$ \__$$/       $$ |__$$ |$$ |__$$ |$$$  \$$ |$$ |/$$/  
            $$      \ $$  \ /$$/ $$    $$ |$$$$  $$ |   $$      \       $$    $$< $$    $$ |$$$$  $$ |$$  $$<   
             $$$$$$  | $$  /$$/  $$$$$$$$ |$$ $$ $$ |    $$$$$$ |      $$$$$$$  |$$$$$$$$ |$$ $$ $$ |$$$$$  \  
            /  \__$$ |  $$ $$/   $$ |  $$ |$$ |$$$$ |   /  \__$$ |      $$ |__$$ |$$ |  $$ |$$ |$$$$ |$$ |$$  \ 
            $$    $$/    $$$/    $$ |  $$ |$$ | $$$ |   $$    $$/       $$    $$/ $$ |  $$ |$$ | $$$ |$$ | $$  |
             $$$$$$/      $/     $$/   $$/ $$/   $$/     $$$$$$/        $$$$$$$/  $$/   $$/ $$/   $$/ $$/   $$/";
        System.Console.WriteLine(title);

        Startmenu startmenu = new Startmenu();
       
    }
} //IDE = Integrated development enviroment. En miljö där man utvecklar där det finns t.ex. bibliotek
// CLI = Command line interface - Det är när när man skriver dotnet kommand 
//CIL = Kod i form av instruktioner. Instruktionerna kompileras sedan till maskin kod.