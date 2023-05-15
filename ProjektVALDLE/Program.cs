//Streak momentálně nicht worken
//Abilitky jsou jen kousek v poli jinak nic
//Agenti hotovy a funkcni PeepoHappy
//U všech agentu je porad pickrate jsem moc linej to dat pryc rn :c
string releaseDate = "";
string role = "";
double pickRate = 0.1;
string Narodnost = "";
string GreleaseDate = "";
string Grole = "";
double GpickRate = 0.1;
string GNarodnost = "";
string gender = "";
string Ggender = "";
int menu = 0;
string choice;
int Streak = 0;
string choice2;
int guess = 0;
int nahodnyindex = 0;
string gamemode = "";

string[] agents = { "Jett","Raze", "Reyna", "Neon", "Phoenix", "Yoru", "Gekko",
    "Sova", "Fade", "Kayo","Skye", "Breach", "Cypher", "Sage", "Killjoy",
    "Chamber", "Omen", "Viper", "Harbor", "Brimstone", "Astra"};
string[] abilities = { "Incendiary", "Sky smoke", "Stim beacon", "Orbital strike", "Curveball", "Hot hands", "Blaze", "Run it back", "Slow orb", "Healing orb",
    "Barrier orb", "Resurrection", "Shock bolt", "Recon bolt", "Owl drone", "Hunter´s fury", "Poison cloud", "Toxic screen", "Snake bite", "Viper´s pit",
 "Cyber cage", "Spycam", "Trapwire", "Neural theft", "Devour", "Dismiss", "Leer", "Empress", 
"Alarmbot", "Turret", "Nanoswarm", "Lockdown", "Flashpoint", "Fault line","Aftershock", "Rolling thunder"};
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("VALDLE!");
Console.ForegroundColor= ConsoleColor.White;

Menu:

while (menu == 0)
{
    Console.WriteLine("1) Start\n2) Momentální streak\n3) EXIT");
    choice = Console.ReadLine();
    if (choice == "1")
    {
        Console.WriteLine("Chceš hádat agenty(1) nebo abilitky(2)?");
       gamemode = Console.ReadLine();
        menu++;
    }
    else if (choice == "2")
    {
        Console.WriteLine($"Momentální streak je {Streak}.");
        Thread.Sleep(5000);
        Console.ReadKey();
    }
    else if (choice == "3")
    {
        goto exit;
    }
}
menu = 0;
if (gamemode == "1")
{
    Random generatorCisel = new Random();
    nahodnyindex = generatorCisel.Next(agents.Length);
    Console.Clear();
    string hadanyAgent = agents[nahodnyindex];
    if (hadanyAgent == "Jett")
    {
        releaseDate = "Beta";
        role = "Duelist";
        pickRate = 10;
        Narodnost = "Jižní Korea";
        gender = "žena";
    }
    else if (hadanyAgent == "Raze")
    {
        releaseDate = "1.0";
        role = "Duelist";
        pickRate = 6.5;
        Narodnost = "Brazílie";
        gender = "žena";
    }
    else if (hadanyAgent == "Reyna")
    {
        releaseDate = "1.0";
        role = "Duelist";
        pickRate = 11.8;
        Narodnost = "Mexico";
        gender = "žena";
    }
    else if (hadanyAgent == "Neon")
    {
        releaseDate = "4.0";
        role = "Duelist";
        pickRate = 2.2;
        Narodnost = "Filipíny";
        gender = "žena";
    }
    else if (hadanyAgent == "Phoenix")
    {
        releaseDate = "Beta";
        role = "Duelist";
        pickRate = 3.4;
        Narodnost = "Británie";
        gender = "muž";
    }
    else if (hadanyAgent == "Yoru")
    {
        releaseDate = "2.0";
        role = "Duelist";
        pickRate = 1.8;
        Narodnost = "Japonsko";
        gender = "muž";
    }
    else if (hadanyAgent == "Gekko")
    {
        releaseDate = "6.04";
        role = "Initiator";
        pickRate = 6.2;
        Narodnost = "USA";
        gender = "muž";
    }
    else if (hadanyAgent == "Sova")
    {
        releaseDate = "Beta";
        role = "Initiator";
        pickRate = 4.2;
        Narodnost = "Rusko";
        gender = "muž";
    }
    else if (hadanyAgent == "Fade")
    {
        releaseDate = "4.08";
        role = "Initiator";
        pickRate = 3.2;
        Narodnost = "Turecko";
        gender = "žena";
    }
    else if (hadanyAgent == "Kayo")
    {
        releaseDate = "3.0";
        role = "Initiator";
        pickRate = 2.7;
        Narodnost = "Alternative Earth";
        gender = "muž";
    }
    else if (hadanyAgent == "Skye")
    {
        releaseDate = "1.11";
        role = "Initiator";
        pickRate = 3.3;
        Narodnost = "Austrálie";
        gender = "žena";
    }
    else if (hadanyAgent == "Breach")
    {
        releaseDate = "Beta";
        role = "Initiator";
        pickRate = 2.6;
        Narodnost = "Švédsko";
        gender = "muž";
    }
    else if (hadanyAgent == "Cypher")
    {
        releaseDate = "Beta";
        role = "Sentinel";
        pickRate = 3.3;
        Narodnost = "Maroko";
        gender = "muž";
    }
    else if (hadanyAgent == "Sage")
    {
        releaseDate = "Beta";
        role = "Sentinel";
        pickRate = 10.7;
        Narodnost = "Čína";
        gender = "žena";
    }
    else if (hadanyAgent == "Killjoy")
    {
        releaseDate = "1.05";
        role = "Sentinel";
        pickRate = 6.5;
        Narodnost = "Německo";
        gender = "žena";
    }
    else if (hadanyAgent == "Chamber")
    {
        releaseDate = "3.10";
        role = "Sentinel";
        pickRate = 2.8;
        Narodnost = "Francie";
        gender = "muž";
    }
    else if (hadanyAgent == "Omen")
    {
        releaseDate = "Beta";
        role = "Controller";
        pickRate = 7.3;
        Narodnost = "Unknown";
        gender = "muž";
    }
    else if (hadanyAgent == "Viper")
    {
        releaseDate = "Beta";
        role = "Controller";
        pickRate = 3.8;
        Narodnost = "USA";
        gender = "žena";
    }
    else if (hadanyAgent == "Harbor")
    {
        releaseDate = "5.08";
        role = "Controller";
        pickRate = 1.1;
        Narodnost = "Indie";
    }
    else if (hadanyAgent == "Brimstone")
    {
        releaseDate = "Beta";
        role = "Controller";
        pickRate = 5;
        Narodnost = "USA";
        gender = "muž";
    }
    else if (hadanyAgent == "Astra")
    {
        releaseDate = "2.04";
        role = "Controller";
        pickRate = 1.5;
        Narodnost = "Ghana";
        gender = "žena";
    }

    while (true)
    {
        Console.WriteLine("Tvuj guess?");
        string odhadAgenta = Console.ReadLine();
        if (odhadAgenta == "Jett")
        {
            GreleaseDate = "Beta";
            Grole = "Duelist";
            GpickRate = 10;
            GNarodnost = "Jižní Korea";
            Ggender = "žena";
        }
        else if (odhadAgenta == "Raze")
        {
            GreleaseDate = "1.0";
            Grole = "Duelist";
            GpickRate = 6.5;
            GNarodnost = "Brazílie";
            Ggender = "žena";
        }
        else if (odhadAgenta == "Reyna")
        {
            GreleaseDate = "1.0";
            Grole = "Duelist";
            GpickRate = 11.8;
            GNarodnost = "Mexico";
            Ggender = "žena";
        }
        else if (odhadAgenta == "Neon")
        {
            GreleaseDate = "4.0";
            Grole = "Duelist";
            GpickRate = 2.2;
            GNarodnost = "Filipíny";
            Ggender = "žena";
        }
        else if (odhadAgenta == "Phoenix")
        {
            GreleaseDate = "Beta";
            Grole = "Duelist";
            GpickRate = 3.4;
            GNarodnost = "Británie";
            Ggender = "muž";
        }
        else if (odhadAgenta == "Yoru")
        {
            GreleaseDate = "2.0";
            Grole = "Duelist";
            GpickRate = 1.8;
            GNarodnost = "Japonsko";
            Ggender = "muž";
        }
        else if (odhadAgenta == "Gekko")
        {
            GreleaseDate = "6.04";
            Grole = "Initiator";
            GpickRate = 6.2;
            GNarodnost = "USA";
            Ggender = "muž";
        }
        else if (odhadAgenta == "Sova")
        {
            GreleaseDate = "Beta";
            Grole = "Initiator";
            GpickRate = 4.2;
            GNarodnost = "Rusko";
            Ggender = "muž";
        }
        else if (odhadAgenta == "Fade")
        {
            GreleaseDate = "4.08";
            Grole = "Initiator";
            GpickRate = 3.2;
            GNarodnost = "Turecko";
            Ggender = "žena";
        }
        else if (odhadAgenta == "Kayo")
        {
            GreleaseDate = "3.0";
            Grole = "Initiator";
            GpickRate = 2.7;
            GNarodnost = "Alternative Earth";
            Ggender = "muž";
        }
        else if (odhadAgenta == "Skye")
        {
            GreleaseDate = "1.11";
            Grole = "Initiator";
            GpickRate = 3.3;
            GNarodnost = "Austrálie";
            Ggender = "žena";
        }
        else if (odhadAgenta == "Breach")
        {
            GreleaseDate = "Beta";
            Grole = "Initiator";
            GpickRate = 2.6;
            GNarodnost = "Švédsko";
            Ggender = "muž";
        }
        else if (odhadAgenta == "Cypher")
        {
            GreleaseDate = "Beta";
            Grole = "Sentinel";
            GpickRate = 3.3;
            GNarodnost = "Maroko";
            Ggender = "muž";
        }
        else if (odhadAgenta == "Sage")
        {
            GreleaseDate = "Beta";
            Grole = "Sentinel";
            GpickRate = 10.7;
            GNarodnost = "Čína";
            Ggender = "žena";
        }
        else if (odhadAgenta == "Killjoy")
        {
            GreleaseDate = "1.05";
            Grole = "Sentinel";
            GpickRate = 6.5;
            GNarodnost = "Německo";
            Ggender = "žena";
        }
        else if (odhadAgenta == "Chamber")
        {
            GreleaseDate = "3.10";
            Grole = "Sentinel";
            GpickRate = 2.8;
            GNarodnost = "Francie";
            Ggender = "muž";
        }
        else if (odhadAgenta == "Omen")
        {
            GreleaseDate = "Beta";
            Grole = "Controller";
            GpickRate = 7.3;
            GNarodnost = "Unknown";
            Ggender = "muž";
        }
        else if (odhadAgenta == "Viper")
        {
            GreleaseDate = "Beta";
            Grole = "Controller";
            GpickRate = 3.8;
            GNarodnost = "USA";
            Ggender = "žena";
        }
        else if (odhadAgenta == "Harbor")
        {
            GreleaseDate = "5.08";
            Grole = "Controller";
            GpickRate = 1.1;
            GNarodnost = "Indie";
            Ggender = "muž";
        }
        else if (odhadAgenta == "Brimstone")
        {
            GreleaseDate = "Beta";
            Grole = "Controller";
            GpickRate = 5;
            GNarodnost = "USA";
            Ggender = "muž";
        }
        else if (odhadAgenta == "Astra")
        {
            GreleaseDate = "2.04";
            Grole = "Controller";
            GpickRate = 1.5;
            GNarodnost = "Ghana";
            Ggender = "žena";
        }
        if (odhadAgenta == hadanyAgent)
        {
            if (releaseDate == GreleaseDate)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Release date {GreleaseDate}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Release date {GreleaseDate}");
            }
            Thread.Sleep(100);
            if (role == Grole)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Role {Grole}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Role {Grole}");
            }
            Thread.Sleep(100);
            if (Narodnost == GNarodnost)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Národnost {GNarodnost}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Národnost {GNarodnost}");
            }
            Thread.Sleep(100);
            if (gender == Ggender)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Pohlaví {Ggender}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Pohlaví {Ggender}");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("GG!");
            Thread.Sleep(1000);
            Console.WriteLine("1)Menu\n2)exit");
            choice2 = Console.ReadLine();
            if (choice2 == "1")
            {
                Console.Clear();
                goto Menu;
            }
            else if (choice2 == "2")
            {
                Console.Clear();
                goto exit;
            }
            else
            {
                Console.WriteLine("?;-;");
            }
        }
        else
        {
            if(releaseDate == GreleaseDate)
            { 
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Release date {GreleaseDate}");
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine($"Release date {GreleaseDate}");
            }
            Thread.Sleep(100);
            if(role == Grole)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Role {Grole}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Role {Grole}");
            }
            Thread.Sleep(100);
            if (Narodnost == GNarodnost)
            {
                Console.ForegroundColor=ConsoleColor.Green;
                Console.WriteLine($"Národnost {GNarodnost}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Národnost {GNarodnost}");
            }
            Thread.Sleep(100);
            if (gender == Ggender)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Pohlaví {Ggender}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Pohlaví {Ggender}");
            }
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
else if(gamemode == "2")
{
    Random generatorCisel = new Random();
    nahodnyindex = generatorCisel.Next(abilities.Length);
}
exit:
Console.WriteLine("To bylo moc ez.... Myslim že je čas nerfnout Chambera.");